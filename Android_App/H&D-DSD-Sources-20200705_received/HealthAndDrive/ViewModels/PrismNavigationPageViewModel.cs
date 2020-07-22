using HealthAndDrive.Events;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace HealthAndDrive.ViewModels
{
    public class PrismNavigationPageViewModel : BindableBase, INavigationAware
    {
        private Color _backgroundColor = Color.White;
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }

        private Color _barBackgroundColor = Color.FromHex("#292f59");
        public Color BarBackgroundColor
        {
            get { return _barBackgroundColor; }
            set { SetProperty(ref _barBackgroundColor, value); }
        }

        private Color _barTextColor = Color.White;
        public Color BarTextColor
        {
            get { return _barTextColor; }
            set { SetProperty(ref _barTextColor, value); }
        }

        //private string _title;
        //public string Title
        //{
        //    get { return _title; }
        //    set { SetProperty(ref _title, value); }
        //}        

        public PrismNavigationPageViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<BarBackgroundColorChangedEvent>().Subscribe(ChangeBackgroundColor);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public async void OnNavigatedTo(INavigationParameters parameters)
        {            
        }

        private void ChangeBackgroundColor(string color)
        {
            BarBackgroundColor = Color.FromHex(color);
        }
    }
}
