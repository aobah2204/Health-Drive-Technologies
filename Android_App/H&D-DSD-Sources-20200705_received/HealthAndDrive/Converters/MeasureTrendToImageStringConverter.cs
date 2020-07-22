using HealthAndDrive.Events.Notifications;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace HealthAndDrive.Converters
{
    public class MeasureTrendToImageStringConverter : IValueConverter
    {
        /// <summary>
        /// This method converts the property by turning an enum value into an int.
        /// </summary>
        /// <param name="value">the property value</param>
        /// <param name="targetType">The object type</param>
        /// <param name="parameter">The command parameter</param>
        /// <param name="culture">The culture info</param>
        /// <returns>The converted property</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MeasureTrend enumValue = (MeasureTrend)value;

            switch (enumValue)
            {
                case MeasureTrend.IncreasingHeavy:
                    return "ic_arrows_top.png";
                case MeasureTrend.Increasing:
                    return "ic_arrows_top_mid.png";
                case MeasureTrend.Constant:
                    return "ic_arrows_mid.png";
                case MeasureTrend.Decreasing:
                    return "ic_arrows_bot_mid.png";
                case MeasureTrend.DecreasingHeavy:
                    return "ic_arrows_bottom.png";
                default:
                    return "ic_arrows_none.png";
            }
        }

        /// <summary>
        /// This method converts back the property by turning an int value into an enum value.
        /// </summary>
        /// <param name="value">the property value</param>
        /// <param name="targetType">The object type</param>
        /// <param name="parameter">The command parameter</param>
        /// <param name="culture">The culture info</param>
        /// <returns>The converted property</returns
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return MeasureTrend.None;
        }
    }
}
