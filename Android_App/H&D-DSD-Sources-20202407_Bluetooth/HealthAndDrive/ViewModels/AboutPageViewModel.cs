using Crossover.Bazarin.PrismLib.ViewModels;
using HealthAndDrive.Tools;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Essentials;

namespace HealthAndDrive.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {

        /// <summary>
        /// Gets or sets the navigate to help command
        /// </summary>
        public ICommand NavigateToWebsiteCommand { get; set; }

        /// <summary>
        /// The Application settings
        /// </summary>
        private AppSettings settings;

        public AboutPageViewModel(INavigationService navigationService, AppSettings settings) : base(navigationService)
        {
            this.settings = settings;

            this.NavigateToWebsiteCommand = new DelegateCommand(async () =>
            {
                await Browser.OpenAsync(new Uri(this.settings.WEBSITE_URL), BrowserLaunchMode.SystemPreferred);
            });
        }        
    }
}
