
namespace HealthAndDrive.ViewModels
{
    using Crossover.Bazarin.PrismLib.ViewModels;
    using HealthAndDrive.Models;
    using HealthAndDrive.RepositoryContracts;
    using HealthAndDrive.Services;
    using HealthAndDrive.Tools;
    using Microsoft.AppCenter.Analytics;
    using Prism.Commands;
    using Prism.Navigation;
    using System;
    using System.Windows.Input;
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public class RootPageViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the current user value
        /// </summary>
        private User currentUser;

        /// <summary>
        /// Gets or sets the current user value
        /// </summary>
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }

            set
            {
                SetProperty(ref currentUser, value);
            }
        }

        /// <summary>
        /// The user repository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Gets or sets the navigate to home command
        /// </summary>
        public ICommand NavigateToHomeCommand { get; set; }

        /// <summary>
        /// Gets or sets the navigate to comfort command
        /// </summary>
        public ICommand NavigateToComfortCommand { get; set; }

        /// <summary>
        /// Gets or sets the navigate to color command
        /// </summary>
        public ICommand NavigateToColorCommand { get; set; }

        /// <summary>
        /// Gets or sets the navigate to calibration command
        /// </summary>
        public ICommand NavigateToCalibrationCommand { get; set; }

        /// <summary>
        /// Gets or sets the navigate to language command
        /// </summary>
        public ICommand NavigateToLanguageCommand { get; set; }

        /// <summary>
        /// Gets or sets the navigate to help command
        /// </summary>
        public ICommand NavigateToHelpCommand { get; set; }

        /// <summary>
        /// Gets or sets the navigate to about command
        /// </summary>
        public ICommand NavigateToAboutCommand { get; set; }


        /// <summary>
        /// Gets or sets the navigate to hidden page command
        /// </summary>
        public ICommand NavigateToHiddenPageCommand { get; set; }


        /// <summary>
        /// The Application settings
        /// </summary>
        private AppSettings settings;

        public RootPageViewModel(INavigationService navigationService, IUserRepository userRepository, AppSettings settings) : base(navigationService)
        {
            this.userRepository = userRepository;
            this.settings = settings;

            this.NavigateToHomeCommand = new DelegateCommand(async () =>
            {
                this.userRepository.ChangeName(this.CurrentUser, "Joël Carlin");
                //await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/MainTabbedPage?selectedTab=HomePage");
                await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/HomePage");
                Analytics.TrackEvent(AnalyticsEvent.HomePageViewed);
            });

            this.NavigateToComfortCommand = new DelegateCommand(async () =>
            {
                await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/MainTabbedPage?selectedTab=DrivePage");
                Analytics.TrackEvent(AnalyticsEvent.DrivePageViewed);
            });

            this.NavigateToColorCommand = new DelegateCommand(async () =>
            {
                await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/MainTabbedPage?selectedTab=DrivePage");
                Analytics.TrackEvent(AnalyticsEvent.DrivePageViewed);
            });

            this.NavigateToCalibrationCommand = new DelegateCommand(async () =>
            {
                await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/MainTabbedPage?selectedTab=DrivePage");
                Analytics.TrackEvent(AnalyticsEvent.DrivePageViewed);
            });

            this.NavigateToLanguageCommand = new DelegateCommand(async () =>
            {
                await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/MainTabbedPage?selectedTab=DrivePage");
                Analytics.TrackEvent(AnalyticsEvent.DrivePageViewed);
            });

            this.NavigateToHelpCommand = new DelegateCommand(async () =>
            {
                await Browser.OpenAsync(new Uri(this.settings.HELP_URL), BrowserLaunchMode.SystemPreferred);
                Analytics.TrackEvent(AnalyticsEvent.HelpPageViewed);
            });

            this.NavigateToAboutCommand = new DelegateCommand(async () =>
            {
                await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/AboutPage");
                Analytics.TrackEvent(AnalyticsEvent.AboutPageViewed);
            });


        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            this.CurrentUser = this.userRepository.GetCurrentUser();
            DependencyService.Get<IFloatingWidgetService>().IsEnable = this.userRepository.GetCurrentUser().IsWidgetEnable;
        }
    }
}
