using HealthAndDrive.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Helpers
{
    public class MeasureZoneHelper
    {
        public static ValueKindEnum ComputeMeasureZone(float currentValue, int minimumGlucoseTreshold, int maximumGlucoseTreshold)
        {
            var result = ValueKindEnum.Normal;
            if (currentValue < minimumGlucoseTreshold - (minimumGlucoseTreshold * 25 / 100))
            {
                result = ValueKindEnum.Low2;
            }
            else if (minimumGlucoseTreshold - (minimumGlucoseTreshold * 25 / 100) <= currentValue && currentValue < minimumGlucoseTreshold - (minimumGlucoseTreshold * 15 / 100))
            {
                result = ValueKindEnum.Low1;
            }
            else if (minimumGlucoseTreshold - (minimumGlucoseTreshold * 15 / 100) <= currentValue && currentValue < minimumGlucoseTreshold)
            {
                result = ValueKindEnum.Low;
            }
            else if (minimumGlucoseTreshold <= currentValue && currentValue < maximumGlucoseTreshold)
            {
                result = ValueKindEnum.Normal;
            }
            else if (maximumGlucoseTreshold <= currentValue && currentValue < maximumGlucoseTreshold + (maximumGlucoseTreshold * 20 / 100))
            {
                result = ValueKindEnum.High;
            }
            else if (maximumGlucoseTreshold + (maximumGlucoseTreshold * 20 / 100) <= currentValue && currentValue < maximumGlucoseTreshold + (maximumGlucoseTreshold * 35 / 100))
            {
                result = ValueKindEnum.High1;
            }
            else if (maximumGlucoseTreshold + (maximumGlucoseTreshold * 35 / 100) <= currentValue)
            {
                result = ValueKindEnum.High2;
            }

            return result;
        }       
    }
}
