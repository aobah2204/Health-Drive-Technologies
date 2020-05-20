using System;

namespace HealthAndDrive.Models
{
    /// <summary>
    /// The chart data model
    /// </summary>
    public class ChartData
    {
        /// <summary>
        /// Gets or sets the glucose time stamp value
        /// </summary>
        public DateTime GlucoseTimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the glucose value
        /// </summary>
        public float GlucoseValue { get; set; }
    }
}
