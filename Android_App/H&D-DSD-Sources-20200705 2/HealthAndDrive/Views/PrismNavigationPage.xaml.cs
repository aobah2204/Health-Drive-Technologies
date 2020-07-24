using Prism.Navigation;
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
    public partial class PrismNavigationPage : NavigationPage
    {
        //Page _lastPage;

        public PrismNavigationPage()
        {
            InitializeComponent();
            //this.Popped += OnPoppedHandler;
            //this.Pushed += OnPushedHandler;
        }

        //void OnPoppedHandler(object sender, NavigationEventArgs e)
        //{
        //    var parameters = new NavigationParameters();

        //    if (_lastPage != null)
        //    {
        //        HandleINavigationAware(_lastPage as INavigationAware, parameters, true);
        //        HandleINavigationAware(_lastPage.BindingContext as INavigationAware, parameters, true);
        //    }

        //    HandleINavigationAware(CurrentPage as INavigationAware, parameters, false);
        //    HandleINavigationAware(CurrentPage.BindingContext as INavigationAware, parameters, false);

        //    _lastPage = CurrentPage;
        //}

        //void OnPushedHandler(object sender, NavigationEventArgs e)
        //{
        //    _lastPage = CurrentPage;
        //}

        //void HandleINavigationAware(INavigationAware aware, NavigationParameters parameters, bool ExecuteFrom)
        //{
        //    if (aware == null) return;

        //    if (ExecuteFrom)
        //    {
        //        aware.OnNavigatedFrom(parameters);
        //    }
        //    else
        //    {
        //        aware.OnNavigatedTo(parameters);
        //    }
        //}
    }
}