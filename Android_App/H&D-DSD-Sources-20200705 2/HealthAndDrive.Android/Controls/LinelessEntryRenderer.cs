using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HealthAndDrive.Controls;
using HealthAndDrive.Droid.Controls;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LinelessEntry), typeof(LinelessEntryRenderer))]
namespace HealthAndDrive.Droid.Controls
{
    public class LinelessEntryRenderer : Xamarin.Forms.Platform.Android.EntryRenderer
    {
        public LinelessEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.Gravity = GravityFlags.CenterVertical;

                if (((Entry)Element).HorizontalTextAlignment == Xamarin.Forms.TextAlignment.End)
                {
                    Control.Gravity = GravityFlags.End;
                    e.NewElement.TextChanged += (a, b) =>
                    {
                        if (Control == null)
                        {
                            return;
                        }
                        Control.Gravity = GravityFlags.End;
                    };
                }
                else if (((Entry)Element).HorizontalTextAlignment == Xamarin.Forms.TextAlignment.Center)
                {
                    Control.Gravity = GravityFlags.Center;
                    e.NewElement.TextChanged += (a, b) =>
                    {
                        if (Control == null)
                        {
                            return;
                        }
                        Control.Gravity = GravityFlags.Center;
                    };
                }
                if (((Entry)Element).HorizontalTextAlignment == Xamarin.Forms.TextAlignment.Start)
                {
                    Control.Gravity = GravityFlags.Start;
                    Control.SetPadding(0, 0, 0, 0);
                    e.NewElement.TextChanged += (a, b) =>
                    {
                        if (Control == null)
                        {
                            return;
                        }
                        Control.Gravity = GravityFlags.Start;
                        Control.SetPadding(0, 0, 0, 0);
                    };
                }
            }
        }
    }
}