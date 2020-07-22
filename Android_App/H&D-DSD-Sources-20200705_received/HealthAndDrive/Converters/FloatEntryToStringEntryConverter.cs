using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace HealthAndDrive.Converters
{
    public class FloatEntryToStringEntryConverter : IValueConverter
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
            string result = string.Empty;
            if ((float)value == 0 || (float)value < 0)
            {
                result = "";
            }
            else
            {
                result = value.ToString();
            }
            return result;
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
            float result;
            if ((string)value == "" || (string)value == "-")
            {
                result = 0;
            }
            else
            {
                result = float.Parse((string)value);
            }
            return result;
        }
    }
}
