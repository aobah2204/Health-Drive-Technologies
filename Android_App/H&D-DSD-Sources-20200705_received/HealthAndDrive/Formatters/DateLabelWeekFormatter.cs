using System;
using Telerik.XamarinForms.Chart;

namespace HealthAndDrive.Formatters
{
    /// <summary>
    /// Week formatter for DateLabelFormatter for telerik chart
    /// </summary>
    public class DateLabelWeekFormatter : LabelFormatterBase<DateTime>
    {
        /// <summary>
        /// For all days in list (used for a list with last 7 days), show them with the sigle J
        /// Example : J, J-1, J-2, J-3...
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override string FormatTypedValue(DateTime value)
        {
            if((int)(DateTime.Now - value).TotalDays != 0)
            {
                int totalDays = (int)(DateTime.Now - value).TotalDays;
                string s = AppResources.ReportsPage_DaysInitial + "-" + totalDays.ToString();
                return s;
            }
            else
            {
                return AppResources.ReportsPage_DaysInitial;
            }
        }
    }
}
