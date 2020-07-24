using Android.Content;
using Android.Graphics.Drawables;
using HealthAndDrive.Droid.Renderers;
using HealthAndDrive.Controls;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FrameRenderer = Xamarin.Forms.Platform.Android.AppCompat.FrameRenderer;


[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace HealthAndDrive.Droid.Renderers
{
    class CustomFrameRenderer : FrameRenderer
    {
        public CustomFrameRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && Control != null)
            {
                UpdateCornerRadius();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == nameof(CustomFrame.CornerRadius) ||
                e.PropertyName == nameof(CustomFrame))
            {
                UpdateCornerRadius();
            }
        }

        private void UpdateCornerRadius()
        {
            if (Control.Background is GradientDrawable backgroundGradient)
            {
                var cornerRadius = (Element as CustomFrame)?.CornerRadius;
                if (!cornerRadius.HasValue)
                {
                    return;
                }

                var topLeftCorner = Context.ToPixels(cornerRadius.Value.TopLeft);
                var topRightCorner = Context.ToPixels(cornerRadius.Value.TopRight);
                var bottomLeftCorner = Context.ToPixels(cornerRadius.Value.BottomLeft);
                var bottomRightCorner = Context.ToPixels(cornerRadius.Value.BottomRight);

                var cornerRadii = new[]
                {
                    topLeftCorner,
                    topLeftCorner,

                    topRightCorner,
                    topRightCorner,

                    bottomRightCorner,
                    bottomRightCorner,

                    bottomLeftCorner,
                    bottomLeftCorner,
                };

                //backgroundGradient.SetCornerRadii(cornerRadii);

                var color1 = (Element as CustomFrame)?.Color1; //#62d248
                var color2 = (Element as CustomFrame)?.Color2; //#8eeb41
                var color3 = (Element as CustomFrame)?.Color3; //#b0eb41

                int[] colors = new[] { Android.Graphics.Color.ParseColor(color1).ToArgb(), 
                    Android.Graphics.Color.ParseColor(color2).ToArgb(),
                Android.Graphics.Color.ParseColor(color3).ToArgb()};

                GradientDrawable gradientDrawable = new GradientDrawable(
                        GradientDrawable.Orientation.TopBottom, colors);

                gradientDrawable.SetCornerRadii(cornerRadii);
                Control.Background = gradientDrawable;
            }
        }

    }
}