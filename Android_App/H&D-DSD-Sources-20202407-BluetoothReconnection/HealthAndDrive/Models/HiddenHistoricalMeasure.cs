using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Models
{
    public class HiddenHistoricalMeasure
    {

        /// <summary>
        /// Gets or sets the Real measure date
        /// </summary>
        public string RealDateTimeOffset { get; set; }

        /// <summary>
        /// Gets or sets the Raw Glucose level (in MGDL)
        /// </summary>
        public float RawGlucoseLevelMGDL { get; set; }

        /// <summary>
        /// Gets or sets the Glucose level (in MGDL)
        /// </summary>
        public float GlucoseLevelMGDL { get; set; }

        /// <summary>
        /// Gets or sets if the value of the Offset
        /// </summary>
        public string CalibrationOffset { get; set; }

    }
}
