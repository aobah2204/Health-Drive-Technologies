using Crossover.Bazarin.Permissions;
using Crossover.Bazarin.PrismLib.ViewModels;
using HealthAndDrive.DependencyServices;
using HealthAndDrive.Tools;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthAndDrive.ViewModels
{
    public class SplashPageViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the class <see cref="SplashPageViewModel"/>
        /// </summary>
        /// <param name="navigationService"></param>
        public SplashPageViewModel(INavigationService navigationService)
             : base(navigationService)
        {
            
        }

        private async Task Initialize()
        {
            await Task.Delay(5000)
                .ContinueWith((t) =>
                   Device.BeginInvokeOnMainThread(async () => await this.NavigationService.NavigateAsync("/RootPage/PrismNavigationPage/HomePage"))
                    );
        }

        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            // Permissions
            try
            {
                await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location, Permission.Phone, Permission.Storage);
                bool allPermissionsGranted = CrossPermissions.Current.CheckAllPermissionsStatusAsync(Permission.Location, Permission.Phone, Permission.Storage);
                if (allPermissionsGranted)
                {
                    await this.Initialize();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                await ShowMessage(Utils.GetTranslation("Permissions_Message"), Utils.GetTranslation("Permissions_Title"), Utils.GetTranslation("OK"), async () =>
                {
                       var closer = DependencyService.Get<ICloseApplication>();
                       closer?.closeApplication();
                });
            }
        }

        /// <summary>
        /// Prompt permissions message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="buttonText"></param>
        /// <param name="afterHideCallback"></param>
        /// <returns></returns>
        public async Task ShowMessage(string message,
            string title,
            string buttonText,
            Action afterHideCallback)
        {
            await App.Current.MainPage.DisplayAlert(title, message, buttonText);

            afterHideCallback?.Invoke();
        }
    }
}
