using Crossover.Bazarin.PrismLib.ViewModels;
using HealthAndDrive.Events;
using HealthAndDrive.Events.Notifications;
using HealthAndDrive.Helpers;
using HealthAndDrive.Models;
using HealthAndDrive.Models.Enums;
using HealthAndDrive.RepositoryContracts;
using HealthAndDrive.Tools;
using Microsoft.AppCenter.Analytics;
using Prism;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
namespace HealthAndDrive.ViewModels
{
    public class DrivePageViewModel : ViewModelBase, IActiveAware
    {
        /// <summary>
        /// Gets or sets the current value
        /// </summary>
        private float currentValue;

        /// <summary>
        /// Gets or sets the current value
        /// </summary>
        private float oldValue;

        /// <summary>
        /// Gets or sets the current value
        /// </summary>
        public float CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                oldValue = currentValue;
                SetProperty(ref currentValue, value);
                UpdateUI();
                RaisePropertyChanged(nameof(this.IsLowValue));
                RaisePropertyChanged(nameof(this.IsLow1Value));
                RaisePropertyChanged(nameof(this.IsLow2Value));
                RaisePropertyChanged(nameof(this.IsNormalValue));
                RaisePropertyChanged(nameof(this.IsHigh1Value));
                RaisePropertyChanged(nameof(this.IsHigh2Value));
                RaisePropertyChanged(nameof(this.IsHighValue));
                RaisePropertyChanged(nameof(this.IsNotExtremValue));
            }
        }

        /// <summary>
        /// Gets or sets the current color 1
        /// </summary>
        private string color1;
        /// <summary>
        /// Gets or sets the current color 1
        /// </summary>
        public string Color1
        {
            get { return color1; }
            set { SetProperty(ref color1, value); }
        }

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
                    eventAggregator.GetEvent<BarTitleChangedEvent>().Publish(AppResources.DrivePage_Title);
                    CurrentValue = this.userRepository.GetCurrentUser().CurrentMeasure;
                    Analytics.TrackEvent(AnalyticsEvent.DrivePageViewed);
                }
                else
                {
                    Color1 = "#292f59";
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                }
            }
        }

        /// <summary>
        /// Gets or sets the private maximum glucose treshold value
        /// </summary>
        private int maximumGlucoseTreshold;

        /// <summary>
        /// Gets or sets the public maximum glucose treshold value
        /// </summary>
        public int MaximumGlucoseTreshold
        {
            get { return maximumGlucoseTreshold; }
            set { SetProperty(ref maximumGlucoseTreshold, value); }
        }

        /// <summary>
        /// Gets or sets the private maximum glucose treshold value
        /// </summary>
        private int minimumGlucoseTreshold;

        /// <summary>
        /// Gets or sets the public maximum glucose treshold value
        /// </summary>
        public int MinimumGlucoseTreshold
        {
            get { return minimumGlucoseTreshold; }
            set { SetProperty(ref minimumGlucoseTreshold, value); }
        }

        /// <summary>
        /// Gets or sets the private last checked value date
        /// </summary>
        private DateTimeOffset lastCheckedValueData;

        /// <summary>
        /// Gets or sets the public last checked value date
        /// </summary>
        public DateTimeOffset LastCheckedValueData
        {
            get { return lastCheckedValueData; }
            set { SetProperty(ref lastCheckedValueData, value); }
        }

        /// <summary>
        /// Gets or sets private the current device battery level
        /// </summary>
        private int currentDeviceBatteryLevel;

        /// <summary>
        /// Gets or sets public the current device battery level
        /// </summary>
        public int CurrentDeviceBatteryLevel
        {
            get { return currentDeviceBatteryLevel; }
            set { SetProperty(ref currentDeviceBatteryLevel, value); }
        }

        /// <summary>
        /// Rouge Low
        /// </summary>
        public bool IsLowValue => this.CurrentValue < MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 25 / 100);
        /// <summary>
        /// Orange foncé low
        /// </summary>
        public bool IsLow1Value => MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 25 / 100) <= this.CurrentValue && this.CurrentValue < MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 15 / 100);
        /// <summary>
        /// Orange low
        /// </summary>
        public bool IsLow2Value => MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 15 / 100) <= this.CurrentValue && this.CurrentValue < MinimumGlucoseTreshold;
        /// <summary>
        /// Vert
        /// </summary>
        public bool IsNormalValue => MinimumGlucoseTreshold <= this.CurrentValue && this.CurrentValue < MaximumGlucoseTreshold;
        /// <summary>
        /// Orange high
        /// </summary>
        public bool IsHigh1Value => MaximumGlucoseTreshold <= this.CurrentValue && this.CurrentValue < MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 20 / 100);
        /// <summary>
        /// Orange foncé high
        /// </summary>
        public bool IsHigh2Value => MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 20 / 100) <= this.CurrentValue && this.CurrentValue < MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 35 / 100);
        /// <summary>
        /// Rouge high
        /// </summary>
        public bool IsHighValue => MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 35 / 100) <= this.CurrentValue;
        /// <summary>
        /// Bool indiquant si la valeur est dans les normes
        /// </summary>
        public bool IsNotExtremValue => !this.IsLowValue && !this.IsHighValue;
        /// <summary>
        /// Le taux augmente
        /// </summary>

        /// <summary>
        /// Gets or sets the private measure trend
        /// </summary>
        private MeasureTrend currentTrend;

        /// <summary>
        /// Gets or sets the public measure trend
        /// </summary>
        public MeasureTrend CurrentTrend
        {
            get { return currentTrend; }
            set { SetProperty(ref currentTrend, value); }
        }

        /// <summary>
        /// Gets or sets the navigate to call command
        /// </summary>
        public ICommand CallCommand { get; }
        
        /// <summary>
        /// The user repository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// The user settings repository
        /// </summary>
        private readonly IUserSettingsRepository userSettingsRepository;

        /// <summary>
        /// The user settings
        /// </summary>
        private readonly UserSettings userSettings;

        /// <summary>
        /// Gets or sets the private dynamic label color
        /// </summary>
        private string dynamicLabelColor;

        /// <summary>
        /// Gets or sets the public dynamic label color
        /// </summary>
        public string DynamicLabelColor
        {
            get { return dynamicLabelColor; }
            set { SetProperty(ref dynamicLabelColor, value); }
        }

        /// <summary>
        /// Gets or sets the private glucose value used in view
        /// </summary>
        private string glucoseValue;

        /// <summary>
        /// Gets or sets the public glucose value used in view
        /// </summary>
        public string GlucoseValue
        {
            get {return glucoseValue; }
            set { SetProperty(ref glucoseValue, value); }
        }

        /// <summary>
        /// Indicate that you want the view to be notified when it is made active or inactive
        /// </summary>
        public event EventHandler IsActiveChanged;

        /// <summary>
        /// The aggregator catching events
        /// </summary>
        private readonly IEventAggregator eventAggregator;

        /// <summary>
        /// The app settings, where useful values are stored
        /// </summary>
        private AppSettings appSettings;

        public DrivePageViewModel(IEventAggregator eventAggregator, INavigationService navigationService, IUserRepository userRepository, 
            IUserSettingsRepository userSettingsRepository, AppSettings settings) : base(navigationService)
        {
            this.eventAggregator = eventAggregator;
            this.userRepository = userRepository;
            this.userSettingsRepository = userSettingsRepository;
            this.appSettings = settings;

            CurrentValue = this.userRepository.GetCurrentUser().CurrentMeasure;
            //The modified value adapted to string format (Hi & Lo)
            GlucoseValue = HiLowValueHelper.NewMeasureToString(CurrentValue);

            userSettings = this.userSettingsRepository.GetCurrentUserSettings();
            MaximumGlucoseTreshold = userSettings.MaximumGlucoseTreshold;
            MinimumGlucoseTreshold = userSettings.MinimumGlucoseTreshold;

            eventAggregator.GetEvent<NotificationMeasureEvent>().Subscribe((notification) => { 
            this.ChangeCurrentValue(notification);
            });

            //Get value battery percentage and last value checked time at startup
            UpdateBatteryAndLastValue();
            //Get trend value at startup
            UpdateTrendValue();

            //Update value battery percentage and last value checked time from event
            eventAggregator.GetEvent<DrivePageDataUpdateEvent>().Subscribe(() => {
                UpdateBatteryAndLastValue();
                UpdateTrendValue();
            });

            //Update value trend value
            eventAggregator.GetEvent<TrendEvent>().Subscribe((trend) => {
                UpdateTrendValue();
            });

            this.CallCommand = new DelegateCommand(async () =>
            {
                if (this.IsLowValue || this.IsHighValue || this.IsLow1Value || this.IsHigh2Value)
                {
                    await Launcher.OpenAsync(new Uri(string.Format("tel:{0}", this.appSettings.EMERGENCY_NUMBER)));
                }
            });

        }              

        /// <summary>
        /// Update the current value
        /// </summary>
        /// <param name="notification"></param>
        private void ChangeCurrentValue(NotificationMeasure notification)
        {
            CurrentValue = notification.NewMeasure;
            GlucoseValue = HiLowValueHelper.NewMeasureToString(CurrentValue);
        }

        /// <summary>
        /// Update value battery percentage, the last value checked time and the last measure value
        /// </summary>
        private void UpdateBatteryAndLastValue()
        {
            User CurrentUsr = this.userRepository.GetCurrentUser();
            if (CurrentUsr != null)
            {
                CurrentDeviceBatteryLevel = CurrentUsr.CurrentBatteryPercent;
                LastCheckedValueData = CurrentUsr.LastMeasureTimeStamp;
                CurrentValue = CurrentUsr.CurrentMeasure;
            }
        }

        /// <summary>
        /// Called to update trend value
        /// </summary>
        private void UpdateTrendValue()
        {
            User CurrentUsr = this.userRepository.GetCurrentUser();
            if (CurrentUsr != null)
            {
                CurrentTrend = CurrentUsr.GetMeasureTrend();
            }
        }

        /// <summary>
        /// Called to update color UI
        /// </summary>
        private void UpdateUI()
        {
            //Rouge low
            if (CurrentValue < MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 25 / 100))
            {
                Color1 = this.appSettings.COLOR_RED;
                if (isActive)
                {
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                    DynamicLabelColor = Color1;
                }
            }
            //Orange foncé low
            else if (MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 25 / 100) <= CurrentValue && CurrentValue < MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 15 / 100))
            {
                Color1 = this.appSettings.COLOR_ORANGE;
                if (isActive)
                {
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                    DynamicLabelColor = Color1;
                }
            }
            //Orange low
            else if (MinimumGlucoseTreshold - (MinimumGlucoseTreshold * 15 / 100) <= CurrentValue && CurrentValue < MinimumGlucoseTreshold)
            {
                Color1 = this.appSettings.COLOR_YELLOW;
                if (isActive)
                {
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                    DynamicLabelColor = Color1;
                }
            }
            //Vert
            else if (MinimumGlucoseTreshold <= CurrentValue && CurrentValue < MaximumGlucoseTreshold)
            {
                Color1 = this.appSettings.COLOR_GREEN;
                if (isActive)
                {
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                    DynamicLabelColor = Color1;
                }
            }
            //Orange high
            else if (MaximumGlucoseTreshold <= CurrentValue && CurrentValue < MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 20 / 100))
            {
                Color1 = this.appSettings.COLOR_YELLOW;
                if (isActive)
                {
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                    DynamicLabelColor = Color1;
                }
            }
            //Orange foncé high
            else if (MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 20 / 100) <= CurrentValue && CurrentValue < MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 35 / 100))
            {
                Color1 = this.appSettings.COLOR_ORANGE;
                if (isActive)
                {
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                    DynamicLabelColor = Color1;
                }
            }
            //Rouge high
            else if (MaximumGlucoseTreshold + (MaximumGlucoseTreshold * 35 / 100) <= CurrentValue)
            {
                Color1 = this.appSettings.COLOR_RED;
                if (isActive)
                {
                    eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Publish(Color1);
                    DynamicLabelColor = Color1;
                }
            }
        }
    }
}
