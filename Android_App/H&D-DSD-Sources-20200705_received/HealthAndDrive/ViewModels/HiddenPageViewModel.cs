using Acr.UserDialogs;
using Android.Util;
using Crossover.Bazarin.PrismLib.ViewModels;
using CsvHelper;
using HealthAndDrive.Events.Notifications;
using HealthAndDrive.Models;
using HealthAndDrive.RepositoryContracts;
using HealthAndDrive.Tools;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HealthAndDrive.ViewModels
{
    public class HiddenPageViewModel : ViewModelBase
    {
        /// <summary>
        /// The tag for the log
        /// </summary>
        private readonly string LOG_TAG = nameof(HiddenPageViewModel);

        /// <summary>
        /// The event aggregator
        /// </summary>
        private readonly IEventAggregator eventAggregator;

        /// <summary>
        /// The glucose measure repository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// The user repository
        /// </summary>
        private readonly IGlucoseMeasureRepository glucoseMeasureRepository;

        /// <summary>
        /// Gets or sets the load historical "in the zone" data command
        /// </summary>
        public ICommand LoadHistoricalDataInTheZoneCommand { get; set; }

        /// <summary>
        /// Gets or sets the load historical "not in the zone" data command
        /// </summary>
        public ICommand LoadHistoricalDataNotInTheZoneCommand { get; set; }

        /// <summary>
        /// Gets or sets the simulate measure value
        /// </summary>
        public ICommand SimulateMeasureValueCommand { get; set; }


        /// <summary>
        /// The simulation measure value
        /// </summary>
        private float simulationMeasureValue = 0;

        /// <summary>
        /// Gets or sets simulation measure value
        /// </summary>
        public float SimulationMeasureValue
        {
            get
            {
                return simulationMeasureValue;
            }

            set
            {
                SetProperty(ref simulationMeasureValue, value);
            }
        }

        /// <summary>
        /// The last recorded measures
        /// </summary>
        private List<HiddenHistoricalMeasure> lastMeasures;

        /// <summary>
        /// Gets or sets The last recorded measures
        /// </summary>
        public List<HiddenHistoricalMeasure> LastMeasures
        {
            get
            {
                return lastMeasures;
            }
            set
            {
                SetProperty(ref lastMeasures, value);
            }
        }

        /// <summary>
        /// The app settings
        /// </summary>
        private AppSettings settings;

        public HiddenPageViewModel(IEventAggregator eventAggregator, INavigationService navigationService, IUserRepository userRepository,
            IGlucoseMeasureRepository glucoseMeasureRepository, AppSettings settings) : base(navigationService)
        {
            this.eventAggregator = eventAggregator;
            this.userRepository = userRepository;
            this.glucoseMeasureRepository = glucoseMeasureRepository;
            this.settings = settings;
            this.LoadHistoricalDataInTheZoneCommand = new DelegateCommand(async () => await LoadHistoricalDataAsync(this.settings.CSV_IN_ZONE_FILENAME));
            this.LoadHistoricalDataNotInTheZoneCommand = new DelegateCommand(async () => await LoadHistoricalDataAsync(this.settings.CSV_NOT_IN_ZONE_FILENAME));
            this.SimulateMeasureValueCommand = new DelegateCommand(async () => await SimulateMeasureValueAsync());
            this.LastMeasures = new List<HiddenHistoricalMeasure>();

            GetLastSixtyMinutesMeasures();
        }

        /// <summary>
        /// Loads Historical measures coming from CSV file
        /// </summary>
        /// <returns></returns>
        private async Task LoadHistoricalDataAsync(string fileName)
        {
            bool confirmed = await App.Current.MainPage.DisplayAlert(Utils.GetTranslation("HiddenPage_LoadConfirmTitle"),
                                    Utils.GetTranslation("HiddenPage_LoadConfirmMessage"),
                                    Utils.GetTranslation("YES"), Utils.GetTranslation("NO"));

            if (!confirmed)
            {
                Log.Debug(LOG_TAG, $"{GetType()} LoadHistoricalDataAsync cancelled");
                return;
            }

            UserDialogs.Instance.ShowLoading(Utils.GetTranslation("WAIT"));

            await Task.Delay(1000); // example purpose only

            Log.Debug(LOG_TAG, $"{GetType()} LoadHistoricalDataAsync confirmed");

            // first, we remove the datas
            this.glucoseMeasureRepository.RemoveAll();
            var currentUser = this.userRepository.GetCurrentUser();
            long countExistingMeasures = this.glucoseMeasureRepository.CountByUser(currentUser.Id);

            if (countExistingMeasures > 0)
                return;

            List<decimal> values = new List<decimal>();

            var stream = this.GetType().Assembly.GetManifestResourceStream(fileName);

            Log.Debug(LOG_TAG, $"{GetType()} LoadHistoricalDataAsync: Reading stream");
            // reading our CSV
            using (var reader = new StreamReader(stream))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader))
                    {
                        while (csv.Read())
                        {
                            values.Add(csv.GetField<decimal>(0));
                        }
                    }
                }
            }

            int count = values.Count;
            DateTimeOffset now = DateTimeOffset.UtcNow;

            Log.Debug(LOG_TAG, $"{GetType()} LoadHistoricalDataAsync: Inserting fake datas");

            String sensorId = Guid.NewGuid().ToString();

            // we create fake datas
            // first value in the CSV file is the most recent. Its date is now
            // next value is. Its date is now - 5 minutes
            for (int i = 0; i < values.Count; i++)
            {
                if (i % 100 == 0)
                    Log.Debug(LOG_TAG, $"{GetType()} LoadHistoricalDataAsync: {i} of {values.Count} datas inserted");

                DateTimeOffset time = now.AddMinutes(-5 * i);
                this.glucoseMeasureRepository.Create(new GlucoseMeasure
                {
                    Id = Guid.NewGuid().ToString(),
                    GlucoseLevelMGDL = (float)values[(count - 1) - i],
                    InTheMedicalZone = this.settings.MEDICAL_ZONE_MGDL_MIN <= (float)values[(count - 1) - i] && (float)values[(count - 1) - i] <= this.settings.MEDICAL_ZONE_MGDL_MAX,
                    SensorId = sensorId,
                    RealDateTimeOffset = time
                }, currentUser.Id);
            }

            // the last measure is the first value in the file
            this.eventAggregator.GetEvent<LastMeasureReceivedEvent>().Publish((float)values[0]);

            UserDialogs.Instance.HideLoading();
        }

        /// <summary>
        /// Simulates a glucose measure. 
        /// It saves the data in the DB and triggers the "last measure received process" (updateUI, alert notifications, vibrations, etc...)
        /// The simulated value is manually given by the user.
        /// </summary>
        /// <returns></returns>
        private async Task SimulateMeasureValueAsync()
        {
            if (this.SimulationMeasureValue < 0)
            {
                UserDialogs.Instance.Toast(Utils.GetTranslation("HiddenPage_SimulateToastPositiveValue"), TimeSpan.FromSeconds(2));
                return;
            }
            this.eventAggregator.GetEvent<LastMeasureReceivedEvent>().Publish(this.SimulationMeasureValue);
            UserDialogs.Instance.Toast(Utils.GetTranslation("HiddenPage_SimulateToastDone"), TimeSpan.FromSeconds(2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task GetLastSixtyMinutesMeasures()
        {
            var currentUser = this.userRepository.GetCurrentUser();
            var measures = this.glucoseMeasureRepository.GetLastSixtyMinutesMeasuresByUser(currentUser.Id);

            this.LastMeasures = new List<HiddenHistoricalMeasure>();

            foreach(var measure in measures)
            {
                HiddenHistoricalMeasure toAdd = new HiddenHistoricalMeasure
                {
                    GlucoseLevelMGDL = measure.GlucoseLevelMGDL,
                    RawGlucoseLevelMGDL = (float)Math.Round((decimal)measure.GlucoseLevelRaw / 10),
                    CalibrationOffset = measure.CalibrationOffset.ToString(),
                    RealDateTimeOffset = measure.RealDateTimeOffset.DateTime.ToLocalTime().ToString("G")
                };

                if(measure.CalibrationOffset > 0)
                {
                    toAdd.CalibrationOffset = $"+{measure.CalibrationOffset}";
                }
                

                this.LastMeasures.Add(toAdd);
            }
        }
    }
}