using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using Crossover.Bazarin.PrismLib.ViewModels;
using Prism.Navigation;
using HealthAndDrive.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Telerik.XamarinForms.Chart;
using HealthAndDrive.Formatters;
using HealthAndDrive.Models.Enums;
using Prism;
using Prism.Events;
using HealthAndDrive.Events;
using HealthAndDrive.RepositoryContracts;
using HealthAndDrive.Tools;
using HealthAndDrive.Helpers;
using System.IO;
using Telerik.Documents.SpreadsheetStreaming;
using HealthAndDrive.Events.Notifications;
using Microsoft.AppCenter.Analytics;

namespace HealthAndDrive.ViewModels
{
    public class ReportsPageViewModel : ViewModelBase, IActiveAware
    {

        /// <summary>
        /// Gets or sets the private char data list
        /// </summary>
        private ObservableCollection<ChartData> chartDataList;

        /// <summary>
        /// Gets or sets the public char data list
        /// </summary>
        public ObservableCollection<ChartData> ChartDataList
        {
            get { return chartDataList; }
            set { SetProperty(ref chartDataList, value); }
        }

        /// <summary>
        /// Gets or sets the private maximum glucose treshold value
        /// </summary>
        private float minimumGlucoseTreshold;

        /// <summary>
        /// Gets or sets the public maximum glucose treshold value
        /// </summary>
        public float MinimumGlucoseTreshold
        {
            get { return minimumGlucoseTreshold; }
            set { SetProperty(ref minimumGlucoseTreshold, value); }
        }

        /// <summary>
        /// Gets or sets the private maximum glucose treshold value
        /// </summary>
        private float maximumGlucoseTreshold;

        /// <summary>
        /// Gets or sets the public maximum glucose treshold value
        /// </summary>
        public float MaximumGlucoseTreshold
        {
            get { return maximumGlucoseTreshold; }
            set { SetProperty(ref maximumGlucoseTreshold, value); }
        }

        /// <summary>
        /// Gets or sets the private comfort zone percentage value
        /// </summary>
        private int comfortZonePercentage = 77;

        /// <summary>
        /// Gets or sets the private comfort zone percentage value
        /// </summary>
        public int ComfortZonePercentage
        {
            get { return comfortZonePercentage; }
            set { SetProperty(ref comfortZonePercentage, value); }
        }

        /// <summary>
        /// Gets or sets the private comfort zone percentage value
        /// </summary>
        private float glucoseAverage = 125.777f;

        /// <summary>
        /// Gets or sets the private comfort zone percentage value
        /// </summary>
        public float GlucoseAverage
        {
            get { return glucoseAverage; }
            set { SetProperty(ref glucoseAverage, value); }
        }

        /// <summary>
        /// Gets or sets the private hemoglobin value
        /// </summary>
        private float hemoglobinValue = 115.15361535f;

        /// <summary>
        /// Gets or sets the private hemoglobin value
        /// </summary>
        public float HemoglobinValue
        {
            get { return hemoglobinValue; }
            set { SetProperty(ref hemoglobinValue, value); }
        }

        /// <summary>
        /// Gets or sets the private annotation dash values
        /// </summary>
        private Double[] annotationDash = { 2.0, 4.0 };

        /// <summary>
        /// Gets or sets the public annotation dash values
        /// </summary>
        public Double[] AnnotationDash
        {
            get { return annotationDash; }
            set { SetProperty(ref annotationDash, value); }
        }

        /// <summary>
        /// Gets or sets the private chart sort by enum value
        /// </summary>
        public ChartSortEnum chartSortValue;

        /// <summary>
        /// Gets or sets the public chart sort by enum value
        /// </summary>
        public ChartSortEnum ChartSortValue
        {
            get { return chartSortValue; }
            set { SetProperty(ref chartSortValue, value); }
        }

        /// <summary>
        /// Gets or sets the private major step unit type enum value
        /// </summary>
        public TimeInterval majorStepUnitType;

        /// <summary>
        /// Gets or sets the public major step unit type enum value
        /// </summary>
        public TimeInterval MajorStepUnitType
        {
            get { return majorStepUnitType; }
            set { SetProperty(ref majorStepUnitType, value); }
        }

        /// <summary>
        /// Gets or sets the private major step value
        /// </summary>
        public float majorStepValue;

        /// <summary>
        /// Gets or sets the public major step value
        /// </summary>
        public float MajorStepValue
        {
            get { return majorStepValue; }
            set { SetProperty(ref majorStepValue, value); }
        }

        /// <summary>
        /// Gets or sets the private first x chart value
        /// </summary>
        public DateTime maximumDate = DateTime.Now.ToLocalTime();

        /// <summary>
        /// Gets or sets the public first x chart value
        /// </summary>
        public DateTime MaximumDate
        {
            get { return maximumDate; }
            set { SetProperty(ref maximumDate, value); }
        }

        /// <summary>
        /// Gets or sets the private first x chart value
        /// </summary>
        public DateTime minimumDate;

        /// <summary>
        /// Gets or sets the public first x chart value
        /// </summary>
        public DateTime MinimumDate
        {
            get { return minimumDate; }
            set { SetProperty(ref minimumDate, value); }
        }

        /// <summary>
        /// Gets or sets the private chart vertical axe max value
        /// </summary>
        private int chartVertAxeMaxValue;

        /// <summary>
        /// Gets or sets the public chart vertical axe max value
        /// </summary>
        public int ChartVertAxeMaxValue
        {
            get { return chartVertAxeMaxValue; }
            set { SetProperty(ref chartVertAxeMaxValue, value); }
        }

        /// <summary>
        /// Gets or sets the private chart vertical axe min value
        /// </summary>
        private int chartVertAxeMinValue;

        /// <summary>
        /// Gets or sets the public chart vertical axe min value
        /// </summary>
        public int ChartVertAxeMinValue
        {
            get { return chartVertAxeMinValue; }
            set { SetProperty(ref chartVertAxeMinValue, value); }
        }

        /// <summary>
        /// Gets or sets the private date label formatter
        /// </summary>
        public LabelFormatterBase<DateTime> dateLabelFormatter;

        /// <summary>
        /// Gets or sets the public date label formatter
        /// </summary>
        public LabelFormatterBase<DateTime> DateLabelFormatter
        {
            get { return dateLabelFormatter; }
            set { SetProperty(ref dateLabelFormatter, value); }
        }


        /// <summary>
        /// The private const for a day in 4 hours
        /// </summary>
        private const float majorStepValueDay = 4f;

        /// <summary>
        /// The private const for a week in days
        /// </summary>
        private const float majorStepValueWeek = 1f;

        /// <summary>
        /// The private const for half a month to show 3 dates
        /// </summary>
        private const float majorStepValueHalfMonth = 7.5f;

        /// <summary>
        /// The private const for a month to show 3 dates
        /// </summary>
        private const float majorStepValueMonth = 15f;

        /// <summary>
        /// The unique user id
        /// </summary>
        private readonly string uniqueUserId;

        /// <summary>
        /// Gets or sets the public SortByDay command
        /// </summary>
        public ICommand SortByDayCommand { get; }

        /// <summary>
        /// Gets or sets the public SortByWeekCommand command
        /// </summary>
        public ICommand SortByWeekCommand { get; }

        /// <summary>
        /// Gets or sets the public SortByHalfMonthCommand command
        /// </summary>
        public ICommand SortByHalfMonthCommand { get; }

        /// <summary>
        /// Gets or sets the public SortByMonthCommand command
        /// </summary>
        public ICommand SortByMonthCommand { get; }

        /// <summary>
        /// Gets or sets the public export command
        /// </summary>
        public ICommand ExportCommand { get; }

        /// <summary>
        /// The event handler
        /// </summary>
        public event EventHandler IsActiveChanged;

        private readonly IEventAggregator eventAggregator;

        /// <summary>
        /// The glucose measure repository
        /// </summary>
        private readonly IGlucoseMeasureRepository glucoseMeasureRepository;

        /// <summary>
        /// The user repository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Gets or sets a boolean value indicating if the tab is active
        /// </summary>
        private bool isActive;
        /// <summary>
        /// Gets or sets a boolean value indicating if the tab is active
        /// </summary>
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                SetProperty(ref isActive, value);
                if (value)
                {
                    eventAggregator.GetEvent<BarTitleChangedEvent>().Publish(AppResources.ReportsPage_Title);
                    this.MinimumGlucoseTreshold = this.userSettingsRepository.GetCurrentUserSettings().MinimumGlucoseTreshold;
                    this.MaximumGlucoseTreshold = this.userSettingsRepository.GetCurrentUserSettings().MaximumGlucoseTreshold;
                    Analytics.TrackEvent(AnalyticsEvent.ReportsPageViewed);
                }
            }
        }

        /// <summary>
        /// The App settings
        /// </summary>
        private AppSettings settings;

        /// <summary>
        /// The user settings repository
        /// </summary>
        private readonly IUserSettingsRepository userSettingsRepository;

        /// <summary>
        /// The reports page viewmodel constructor
        /// </summary>
        /// <param name="ea"></param>
        /// <param name="glucoseMeasureRepository"></param>
        /// <param name="navigationService"></param>
        public ReportsPageViewModel(IEventAggregator eventAggregator, IGlucoseMeasureRepository glucoseMeasureRepository, IUserRepository userRepository, 
            INavigationService navigationService, IUserSettingsRepository userSettingsRepository, AppSettings settings)
            : base(navigationService)
        {
            //Repositories init
            this.eventAggregator = eventAggregator;
            this.glucoseMeasureRepository = glucoseMeasureRepository;
            this.userRepository = userRepository;
            this.settings = settings;
            this.userSettingsRepository = userSettingsRepository;
            this.ChartVertAxeMaxValue = this.settings.CHART_VERT_AXE_MAX;
            this.ChartVertAxeMinValue = this.settings.CHART_VERT_AXE_MIN;

            this.uniqueUserId = userRepository.GetCurrentUser().Id;
            this.ChartDataList = new ObservableCollection<ChartData>();

            this.MinimumGlucoseTreshold = this.userSettingsRepository.GetCurrentUserSettings().MinimumGlucoseTreshold;
            this.MaximumGlucoseTreshold = this.userSettingsRepository.GetCurrentUserSettings().MaximumGlucoseTreshold;

            //Initialize
            ChartSortValue = ChartSortEnum.SortByDay;
            this.ChartDataList = GetChartData();
            MajorStepUnitType = TimeInterval.Hour;
            this.MajorStepValue = majorStepValueDay;

            this.SortByDayCommand = new DelegateCommand(() =>
            {
                ChartSortValue = ChartSortEnum.SortByDay;
                this.ChartDataList = GetChartData();
                MajorStepUnitType = TimeInterval.Hour;
                this.MajorStepValue = majorStepValueDay;
                this.DateLabelFormatter = null;
            });

            this.SortByWeekCommand = new DelegateCommand(() =>
            {
                ChartSortValue = ChartSortEnum.SortByWeek;
                this.ChartDataList = GetChartDataByWeek();
                MajorStepUnitType = TimeInterval.Day;
                this.MajorStepValue = majorStepValueWeek;
                this.DateLabelFormatter = new DateLabelWeekFormatter();
            });

            this.SortByHalfMonthCommand = new DelegateCommand(() =>
            {
                ChartSortValue = ChartSortEnum.SortByHalfMonth;
                this.ChartDataList = GetChartDataByHalfMonth();
                MajorStepUnitType = TimeInterval.Day;
                this.MajorStepValue = majorStepValueHalfMonth;
                this.DateLabelFormatter = null;
            });

            this.SortByMonthCommand = new DelegateCommand(() =>
            {
                ChartSortValue = ChartSortEnum.SortByMonth;
                this.ChartDataList = GetChartDataByMonth();
                MajorStepUnitType = TimeInterval.Day;
                this.MajorStepValue = majorStepValueMonth;
                this.DateLabelFormatter = null;
            });

            this.ExportCommand = new DelegateCommand(() =>
            {
                try
                {
                    List<GlucoseMeasure> input = glucoseMeasureRepository.GetAllMeasuresByUser(uniqueUserId);
                    List<CsvGlucoseMeasure> output = CSVHelper.ConvertGlucoseToCsvGlucoseFormat(input);
                    //string s = CSVHelper.GetCSV(output);

                    var pathFile = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads);
                    string filename = Path.Combine(pathFile.ToString(), "H&D_Datas.csv");

                    GenerateDocument(filename, output);
                }
                catch (Exception ex)
                {

                }
            });

            LoadAveragesData();

            this.eventAggregator.GetEvent<NotificationMeasureEvent>().Subscribe((notification) => { 
                LoadAveragesData();
                this.ChartDataList = GetChartData();
            });

        }

        private static void GenerateDocument(string filePath, List<CsvGlucoseMeasure> output)
        {
            using (FileStream stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                using (IWorkbookExporter workbook = SpreadExporter.CreateWorkbookExporter(SpreadDocumentFormat.Csv, stream))
                {
                    // Creating a style which would be used later in the code.
                    //SpreadCellStyle style = workbook.CellStyles.Add("MyStyle");
                    //style.Underline = SpreadUnderlineType.None;
                    //style.VerticalAlignment = SpreadVerticalAlignment.Center;

                    using (IWorksheetExporter worksheet = workbook.CreateWorksheetExporter("Data"))
                    {
                        //Entête de colonne
                        using (IRowExporter row = worksheet.CreateRowExporter())
                        {
                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetValue("Date");
                            }
                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetValue("Taux de glucose");
                            }
                            using (ICellExporter cell = row.CreateCellExporter())
                            {
                                cell.SetValue("Dans de la zone de confort");
                            }
                        }
                        //Contenu
                        foreach (var data in output)
                        {
                            using (IRowExporter row = worksheet.CreateRowExporter())
                            {
                                using (ICellExporter cell = row.CreateCellExporter())
                                {
                                    cell.SetValue(data.RealDateTimeOffset);
                                }
                                using (ICellExporter cell = row.CreateCellExporter())
                                {
                                    cell.SetValue(data.GlucoseLevelMGDL);
                                }
                                using (ICellExporter cell = row.CreateCellExporter())
                                {
                                    cell.SetValue(data.InTheMedicalZone == true ? "Oui" : "Non");
                                }
                            }
                        }
                    }
                }
            }
            App.Current.MainPage.DisplayAlert("Export réussi !", "Fichier exporté avec succès vers le répertoire de téléchargements.", "OK");
        }


        /// <summary>
        /// Get chart values from last 24 hours
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<ChartData> GetChartData()
        {
            List<GlucoseMeasure> result = glucoseMeasureRepository.GetLastDayMeasuresByUser(uniqueUserId);
            if (result != null && result.Count > 0)
            {
                DateTime minDateTimeTmp = result.FirstOrDefault().RealDateTimeOffset.DateTime.ToLocalTime();
                this.MinimumDate = new DateTime(minDateTimeTmp.Ticks - minDateTimeTmp.Ticks % TimeSpan.TicksPerHour, minDateTimeTmp.Kind);
            }
            return DataMesureToChartData(result);
        }

        /// <summary>
        /// Get chart values from last 7 days
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<ChartData> GetChartDataByWeek()
        {
            List<GlucoseMeasure> result = glucoseMeasureRepository.GetLastWeekMeasuresByUser(uniqueUserId);
            if (result != null && result.Count > 0)
            {
                this.MinimumDate = result.FirstOrDefault().RealDateTimeOffset.DateTime.ToLocalTime();
            }
            return DataMesureToChartData(result);
        }

        /// <summary>
        /// Get chart values from last 15 days
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<ChartData> GetChartDataByHalfMonth()
        {
            List<GlucoseMeasure> result = glucoseMeasureRepository.GetLastHalfMonthMeasuresByUser(uniqueUserId);
            if (result != null && result.Count > 0)
            {
                this.MinimumDate = result.FirstOrDefault().RealDateTimeOffset.DateTime.ToLocalTime();
            }
            return DataMesureToChartData(result);
        }

        /// <summary>
        /// Get chart values from last 30 days
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<ChartData> GetChartDataByMonth()
        {
            List<GlucoseMeasure> result = glucoseMeasureRepository.GetLastMonthMeasuresByUser(uniqueUserId);
            if (result != null && result.Count > 0)
            {
                this.MinimumDate = result.FirstOrDefault().RealDateTimeOffset.DateTime.ToLocalTime();
            }
            return DataMesureToChartData(result);
        }

        /// <summary>
        /// Convert from glucose measure
        /// </summary>
        /// <param name="mesures"></param>
        /// <returns></returns>
        private ObservableCollection<ChartData> DataMesureToChartData(List<GlucoseMeasure> measures)
        {
            ObservableCollection<ChartData> output = new ObservableCollection<ChartData>();

            foreach (GlucoseMeasure measure in measures)
            {
                float glucoseLevel;
                //If the glucose level is in mg/dl
                if (this.settings.HANDLE_MGDL_MEASURE)
                {
                    glucoseLevel = measure.GlucoseLevelMGDL;
                }
                //Else the glucose is in mmol
                else
                {
                    glucoseLevel = measure.GlucoseLevelMMOL;
                }

                ChartData loopValue = new ChartData()
                {
                    GlucoseTimeStamp = measure.RealDateTimeOffset.DateTime.ToLocalTime(), //Need to convert it to local UTC, so UTC+1
                    GlucoseValue = glucoseLevel
                };
                output.Add(loopValue);
            }
            output = new ObservableCollection<ChartData>(output.OrderBy(x => x.GlucoseTimeStamp).ToList());
            return output;
        }

        private void LoadAveragesData()
        {
            this.GlucoseAverage = this.userRepository.GetCurrentUser().AverageGlycemia;
            this.ComfortZonePercentage = (int)this.userRepository.GetCurrentUser().AverageInTheMedicalZone;
            this.HemoglobinValue = this.userRepository.GetCurrentUser().HBA1C;
        }

    }
}
