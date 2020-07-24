using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthAndDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            this.Initialize();
        }

        private async void Initialize()
        {
            await Task.Delay(2000);
            splashAnim.Play();
            Device.BeginInvokeOnMainThread(async () => await imgSplashLogo.FadeTo(1, 2000));
            Device.BeginInvokeOnMainThread(async () => await TitleSplash.FadeTo(1, 2000));
            Device.BeginInvokeOnMainThread(async () => await TitleSplashOrange.FadeTo(1, 2000));
        }
    }
}