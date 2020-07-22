
namespace HealthAndDrive.Views
{
    using System;
    using Xamarin.Forms;

    public partial class RootPage : MasterDetailPage
    {

        private DateTime? LastTap = null;
        private byte NumberOfTaps = 0;

        private const int NumberOfTapsRequired = 4;
        private const int ToleranceInMs = 1000;

        public RootPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event allows to close the main menu
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event args</param>
        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            this.IsPresented = false;
        }

        /// <summary>
        /// This event allows to close the main menu
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event args</param>
        private void TapHiddenGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {

            if (LastTap == null || (DateTime.Now - LastTap.Value).TotalMilliseconds < ToleranceInMs)
            {
                if (NumberOfTaps == (NumberOfTapsRequired - 1))
                {
                    NumberOfTaps = 0;
                    LastTap = null;
                    var navigationService = (Xamarin.Forms.Application.Current as App).GetNavigationService();
                    navigationService.NavigateAsync("/RootPage/PrismNavigationPage/HiddenPage");
                    return;
                }
                else
                {
                    NumberOfTaps++;
                    LastTap = DateTime.Now;
                }
            }
            else
            {
                NumberOfTaps = 1;
                LastTap = DateTime.Now;
            }

        }

    }
}