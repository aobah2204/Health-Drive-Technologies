
using Acr.UserDialogs;
using Android.App;
using Android.OS;

namespace HealthAndDrive.Droid
{
    [Activity(Label = "DSD", MainLauncher = true, Theme = "@style/Theme.Splash", Icon = "@mipmap/ic_launcher", NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashLayout);


           UserDialogs.Init(this);

            StartActivity(typeof(MainActivity));
        }

    }
}