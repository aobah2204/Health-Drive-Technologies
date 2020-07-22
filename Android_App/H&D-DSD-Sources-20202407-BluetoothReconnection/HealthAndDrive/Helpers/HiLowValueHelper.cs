using HealthAndDrive.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Helpers
{
    /// <summary>
    /// This helps to convert a string to a correct format when Hi or Low value
    /// </summary>
    public class HiLowValueHelper
    {

        /// <summary>
        /// Return the new measure into an adequate string
        /// </summary>
        /// <param name="notification"></param>
        /// <returns></returns>
        public static string NewMeasureToString(float value)
        {
            AppSettings settings = new AppSettings();
            string result = String.Empty;
            if (value <= settings.LO_VALUE)
            {
                result = AppResources.DrivePage_Low;
            }
            else if (settings.HI_VALUE <= value)
            {
                result = AppResources.DrivePage_High;
            }
            else
            {
                result = value.ToString();
            }
            return result;
        }
    }
}
