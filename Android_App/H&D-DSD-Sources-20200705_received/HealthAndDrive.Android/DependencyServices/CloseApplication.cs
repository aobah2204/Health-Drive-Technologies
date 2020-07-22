using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HealthAndDrive.DependencyServices;
using HealthAndDrive.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplication))]
namespace HealthAndDrive.Droid.DependencyServices
{
    /// <summary>
    /// Dependency service used to close application on Android
    /// </summary>
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            var activity = (Activity)Forms.Context;
            activity.FinishAffinity();
        }
    }
}