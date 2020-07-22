using System.Windows.Input;
using Crossover.Bazarin.PrismLib.ViewModels;
using HealthAndDrive.Events;
using HealthAndDrive.Models;
using HealthAndDrive.RepositoryContracts;
using HealthAndDrive.Tools;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;

namespace HealthAndDrive.ViewModels
{
    public class MainTabbedPageViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the private title of the current page value
        /// </summary>
        private string _title;

        /// <summary>
        /// Gets or sets the public title of the current page value
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        /// Gets or sets the current user value
        /// </summary>
        private User currentUser;

        /// <summary>
        /// Gets or sets the current user value
        /// </summary>
        public User CurrentUser
        {
            get { return currentUser; }
            set { SetProperty(ref currentUser, value); }
        }

        /// <summary>
        /// The user repository
        /// </summary>
        private readonly IUserRepository userRepository;

       /// <summary>
       /// Get the alert command
       /// </summary>
        public ICommand AlertsCommand { get;  }

        /// <summary>
        /// The app settings
        /// </summary>
        private AppSettings appSettings;

        public MainTabbedPageViewModel(INavigationService navigationService, IEventAggregator ea, IUserRepository userRepository) : base(navigationService)
        {
            ea.GetEvent<BarTitleChangedEvent>().Subscribe(ChangeTitle);
            this.userRepository = userRepository;
            this.appSettings = new AppSettings();

            this.CurrentUser = this.userRepository.GetCurrentUser();

            this.AlertsCommand = new DelegateCommand(async () =>
            {
                await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/MainTabbedPage?selectedTab=AlertsPage");
            }, CanExecuteNavigation);
        }

        /// <summary>
        /// The event fired to update the page title in the navbar
        /// </summary>
        /// <param name="title"></param>
        private void ChangeTitle(string title)
        {
            Title = title;
        }

        /// <summary>
        /// Check if the navigation service can redirect to the alerts page
        /// </summary>
        /// <returns></returns>
        private bool CanExecuteNavigation()
        {
            return Title != appSettings.ALERTS_PAGE_NAME;
        }
    }
}