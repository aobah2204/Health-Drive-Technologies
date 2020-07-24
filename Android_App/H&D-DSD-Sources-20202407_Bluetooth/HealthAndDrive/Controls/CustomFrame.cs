using Xamarin.Forms;

namespace HealthAndDrive.Controls
{
    public class CustomFrame : Frame
    {
        public static new readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CustomFrame), typeof(CornerRadius), typeof(CustomFrame));

        public static readonly BindableProperty Color1Property = BindableProperty.Create(nameof(CustomFrame), typeof(string), typeof(CustomFrame));
        public static readonly BindableProperty Color2Property = BindableProperty.Create(nameof(CustomFrame), typeof(string), typeof(CustomFrame));
        public static readonly BindableProperty Color3Property = BindableProperty.Create(nameof(CustomFrame), typeof(string), typeof(CustomFrame));

        public CustomFrame()
        {
            // MK Clearing default values (e.g. on iOS it's 5)
            base.CornerRadius = 0;
        }

        public new CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public string Color1
        {
            get => (string)GetValue(Color1Property);
            set => SetValue(Color1Property, value);
        }

        public string Color2
        {
            get => (string)GetValue(Color2Property);
            set => SetValue(Color2Property, value);
        }

        public string Color3
        {
            get => (string)GetValue(Color3Property);
            set => SetValue(Color3Property, value);
        }
    }
}
