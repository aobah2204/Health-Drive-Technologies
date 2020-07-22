using System;
using System.Globalization;
using Xamarin.Forms;

namespace HealthAndDrive.Converters
{
    /// <summary>
    /// This class is a xaml converter. It allows to negate a boolean value.
    /// </summary>
    public class NegateBooleanConverter : IValueConverter
    {
        /// <summary>
        /// This method converts the property by negating its boolean value it.
        /// </summary>
        /// <param name="value">the property value</param>
        /// <param name="targetType">The object type</param>
        /// <param name="parameter">The command parameter</param>
        /// <param name="culture">The culture info</param>
        /// <returns>The converted property</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !System.Convert.ToBoolean(value);
        }

        /// <summary>
        /// This method converts back the property by negating its boolean value it.
        /// </summary>
        /// <param name="value">the property value</param>
        /// <param name="targetType">The object type</param>
        /// <param name="parameter">The command parameter</param>
        /// <param name="culture">The culture info</param>
        /// <returns>The converted property</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !System.Convert.ToBoolean(value);
        }
    }
}
