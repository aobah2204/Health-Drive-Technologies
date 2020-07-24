using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace HealthAndDrive.Converters
{
    public class DateTimeOffsetToStringFormatConverter : IValueConverter
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
            DateTimeOffset input = (DateTimeOffset)value;
            DateTimeOffset empty;
            string output = string.Empty;
            if (input != null && input.Year != empty.Year)
            {
                output = input.ToLocalTime().Day.ToString("00") + "/" + input.ToLocalTime().Month.ToString("00") + " - " + input.ToLocalTime().Hour.ToString("00") + ":" + input.ToLocalTime().Minute.ToString("00");
            }
            else
            {
                output = "--/-- - --:--";
            }
            return output;
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
            return DateTimeOffset.Now;
        }
    }
}
