using Crossover.Bazarin.PrismLib.ViewModels;
using HealthAndDrive.Events;
using HealthAndDrive.Models;
using HealthAndDrive.Models.Enums;
using HealthAndDrive.RepositoryContracts;
using HealthAndDrive.Services;
using HealthAndDrive.Tools;
using Microsoft.AppCenter.Analytics;
using Prism;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HealthAndDrive.ViewModels
{
    public class AlertsPageViewModel : ViewModelBase, IActiveAware
    {

        /// <summary>
        /// Gets or sets the private alert activating bool value
        /// </summary>
        private bool isAlertActivated;

        /// <summary>
        /// Gets or sets the public alert activating bool value
        /// </summary>
        public bool IsAlertActivated
        {
            get { return isAlertActivated; }
            set
            {
                SetProperty(ref isAlertActivated, value);
                this.userRepository.ChangeIsAlarm(this.userRepository.GetCurrentUser(), isAlertActivated);
            }
        }

        /// <summary>
        /// Gets or sets the private widget enable bool value
        /// </summary>
        private bool isWidgetEnable;

        /// <summary>
        /// Gets or sets the public widget enable bool value
        /// </summary>
        public bool IsWidgetEnable
        {
            get { return isWidgetEnable; }
            set
            {
                SetProperty(ref isWidgetEnable, value);
                DependencyService.Get<IFloatingWidgetService>().IsEnable = isWidgetEnable;
                this.userRepository.ChangeIsWidgetEnable(this.userRepository.GetCurrentUser(), isWidgetEnable);
            }
        }

        /// <summary>
        /// Gets or sets the private entry focused boolean
        /// </summary>
        private bool isEntryMaxFocused;

        /// <summary>
        /// Gets or sets the public entry focused boolean
        /// </summary>
        public bool IsEntryMaxFocused
        {
            get { return isEntryMaxFocused; }
            set { SetProperty(ref isEntryMaxFocused, value); }
        }

        /// <summary>
        /// Gets or sets the private entry focused boolean
        /// </summary>
        private bool isEntryMinFocused;

        /// <summary>
        /// Gets or sets the public entry focused boolean
        /// </summary>
        public bool IsEntryMinFocused
        {
            get { return isEntryMinFocused; }
            set { SetProperty(ref isEntryMinFocused, value); }
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
        /// Save temporary the maximum glucose old value for default value
        /// </summary>
        private int MaxGlucoseTmp;

        /// <summary>
        /// Save temporary the minimal glucose old value for default value
        /// </summary>
        private int MinGlucoseTmp;

        /// <summary>
        /// Event if the tab is active
        /// </summary>
        public event EventHandler IsActiveChanged;

        /// <summary>
        /// The event aggregator
        /// </summary>
        private readonly IEventAggregator eventAggregator;

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
                    eventAggregator.GetEvent<BarTitleChangedEvent>().Publish(AppResources.AlertsPage_Title);
                    Analytics.TrackEvent(AnalyticsEvent.AlertsPageViewed);

                }
            }
        }

        /// <summary>
        /// Gets or sets the private max focus value
        /// </summary>
        private MaxMinFocusedEnum focusValueMax;

        /// <summary>
        /// Gets or sets the public max focus value
        /// </summary>
        public MaxMinFocusedEnum FocusValueMax
        {
            get { return focusValueMax; }
            set { SetProperty(ref focusValueMax, value); }
        }

        /// <summary>
        /// Gets or sets the private min focus value
        /// </summary>
        private MaxMinFocusedEnum focusValueMin;

        /// <summary>
        /// Gets or sets the public min focus value
        /// </summary>
        public MaxMinFocusedEnum FocusValueMin
        {
            get { return focusValueMin; }
            set { SetProperty(ref focusValueMin, value); }
        }

        /// <summary>
        /// Gets or sets the public focused max value button command
        /// </summary>
        public ICommand FocusMaxGlucoseCommand { get; set; }

        /// <summary>
        /// Gets or sets the public focused min value button command
        /// </summary>
        public ICommand FocusMinGlucoseCommand { get; set; }

        /// <summary>
        /// Gets or sets the public max unfocused value button command
        /// </summary>
        public ICommand UnfocusMaxCommand { get; set; }

        /// <summary>
        /// Gets or sets the public min unfocused value button command
        /// </summary>
        public ICommand UnfocusMinCommand { get; set; }

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
        private UserSettings userSettings;

        /// <summary>
        /// The application settings
        /// </summary>
        private AppSettings settings;

        public AlertsPageViewModel(IEventAggregator ea, INavigationService navigationService, IUserRepository userRepository, IUserSettingsRepository userSettingsRepository,
            AppSettings settings)
            : base(navigationService)
        {
            //Repositories init
            eventAggregator = ea;
            this.userRepository = userRepository;
            this.userSettingsRepository = userSettingsRepository;
            this.settings = settings;

            userSettings = this.userSettingsRepository.GetCurrentUserSettings();
            MaximumGlucoseTreshold = userSettings.MaximumGlucoseTreshold;
            MinimumGlucoseTreshold = userSettings.MinimumGlucoseTreshold;

            this.FocusValueMax = MaxMinFocusedEnum.NoFocus;
            this.FocusValueMin = MaxMinFocusedEnum.NoFocus;

            this.IsAlertActivated = this.userRepository.GetCurrentUser().IsAlert;

            this.IsWidgetEnable = this.userRepository.GetCurrentUser().IsWidgetEnable;

            this.FocusMaxGlucoseCommand = new DelegateCommand(() =>
            {
                InitFocusMaxGlucoseCommand();
            });

            this.FocusMinGlucoseCommand = new DelegateCommand(() =>
            {
                InitFocusMinGlucoseCommand();
            });

            this.UnfocusMaxCommand = new DelegateCommand(() =>
            {
                InitUnfocusMaxCommand();
            });

            this.UnfocusMinCommand = new DelegateCommand(() =>
            {
                InitUnfocusMinCommand();
            });
        }

        private void InitFocusMaxGlucoseCommand()
        {
            this.FocusValueMax = MaxMinFocusedEnum.MaxFocused;
            this.FocusValueMin = MaxMinFocusedEnum.NoFocus;
            MaxGlucoseTmp = MaximumGlucoseTreshold;
            this.MaximumGlucoseTreshold = 0;

            MessagingCenter.Send(this, "FocusManagement", MaxMinFocusedEnum.MaxFocused);
        }

        private void InitFocusMinGlucoseCommand()
        {
            this.FocusValueMax = MaxMinFocusedEnum.NoFocus;
            this.FocusValueMin = MaxMinFocusedEnum.MinFocused;
            MinGlucoseTmp = MinimumGlucoseTreshold;
            this.MinimumGlucoseTreshold = 0;

            MessagingCenter.Send(this, "FocusManagement", MaxMinFocusedEnum.MinFocused);
        }

        private void InitUnfocusMaxCommand()
        {
            //Visual management
            if (this.FocusValueMin == MaxMinFocusedEnum.MinFocused)
            {
                this.FocusValueMax = MaxMinFocusedEnum.NoFocus;
                this.FocusValueMin = MaxMinFocusedEnum.MinFocused;
            }
            else
            {
                this.FocusValueMax = MaxMinFocusedEnum.NoFocus;
                this.FocusValueMin = MaxMinFocusedEnum.NoFocus;
            }

            //Max and min management of the maximum glucose value
            if (MaximumGlucoseTreshold == 0)
            {
                MaximumGlucoseTreshold = MaxGlucoseTmp;
            }
            else if (MaximumGlucoseTreshold > this.settings.ALERTS_MAX_OF_MAX_GLUCOSE_VALUE)
            {
                MaximumGlucoseTreshold = this.settings.ALERTS_MAX_OF_MAX_GLUCOSE_VALUE;
            }
            else if (MaximumGlucoseTreshold < this.settings.ALERTS_MIN_OF_MAX_GLUCOSE_VALUE)
            {
                MaximumGlucoseTreshold = this.settings.ALERTS_MIN_OF_MAX_GLUCOSE_VALUE;
            }

            this.userSettingsRepository.UpdateMaximumGlucoseTreshold(userSettings, MaximumGlucoseTreshold);
        }

        private void InitUnfocusMinCommand()
        {
            if (this.FocusValueMax == MaxMinFocusedEnum.MaxFocused)
            {
                this.FocusValueMax = MaxMinFocusedEnum.MaxFocused;
                this.FocusValueMin = MaxMinFocusedEnum.NoFocus;
            }
            else
            {
                this.FocusValueMax = MaxMinFocusedEnum.NoFocus;
                this.FocusValueMin = MaxMinFocusedEnum.NoFocus;
            }
            //Max and min management of the minimum glucose value
            if (MinimumGlucoseTreshold == 0)
            {
                MinimumGlucoseTreshold = MinGlucoseTmp;
            }
            else if (MinimumGlucoseTreshold > this.settings.ALERTS_MAX_OF_MIN_GLUCOSE_VALUE)
            {
                MinimumGlucoseTreshold = this.settings.ALERTS_MAX_OF_MIN_GLUCOSE_VALUE;
            }
            else if (MinimumGlucoseTreshold < this.settings.ALERTS_MIN_OF_MIN_GLUCOSE_VALUE)
            {
                MinimumGlucoseTreshold = this.settings.ALERTS_MIN_OF_MIN_GLUCOSE_VALUE;
            }

            this.userSettingsRepository.UpdateMinimumGlucoseTreshold(userSettings, MinimumGlucoseTreshold);
        }
    }
}
