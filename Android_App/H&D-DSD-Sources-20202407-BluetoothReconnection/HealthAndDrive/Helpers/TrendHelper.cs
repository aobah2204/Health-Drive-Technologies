using HealthAndDrive.Events.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Helpers
{
    public class TrendHelper
    {
        /// <summary>
        /// The first value treshold
        /// </summary>
        private const float firstTreshold = 15f;

        /// <summary>
        /// The last value treshold
        /// </summary>
        private const float lastTreshold = 30f;

        /// <summary>
        /// Compute the trend for the measures
        /// </summary>
        /// <param name="currentValue"></param>
        /// <param name="lastFifteenValue"></param>
        /// <returns></returns>
        public static MeasureTrend ValuesToTypeTrend(float? currentValue, float? lastFifteenValue)
        {
            var result = MeasureTrend.None;
            float? valueDifference = currentValue - lastFifteenValue;

            if (-firstTreshold <= valueDifference && valueDifference <= firstTreshold)
            {
                // →
                // -15 <= x <= 15
                result = MeasureTrend.Constant;
            }
            else if (firstTreshold < valueDifference && valueDifference < lastTreshold)
            {
                // ↗
                // 15 < x <= 30
                result = MeasureTrend.Increasing;
            }
            else if (lastTreshold < valueDifference)
            {
                // ↑
                // 30 < x
                result = MeasureTrend.IncreasingHeavy;
            }
            else if (-lastTreshold < valueDifference && valueDifference < -firstTreshold)
            {
                // ↘
                // -30 >= x > -15
                result = MeasureTrend.Decreasing;
            }
            else if (valueDifference < -lastTreshold)
            {
                // ↓
                // x > -30
                result = MeasureTrend.DecreasingHeavy;
            }
            else
            {
                result = MeasureTrend.None;
            }
            return result;
        }
    }
}
