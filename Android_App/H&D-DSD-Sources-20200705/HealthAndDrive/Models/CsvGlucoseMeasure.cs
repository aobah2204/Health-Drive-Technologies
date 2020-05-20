using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Models
{
    public class CsvGlucoseMeasure
    {
        /// <summary>
        /// Gets or sets the Real measure date
        /// </summary>
        public string RealDateTimeOffset { get; set; }

        /// <summary>
        /// Gets or sets the Glucose level (in MGDL)
        /// </summary>
        public float GlucoseLevelMGDL { get; set; }

        /// <summary>
        /// Gets or sets if the value is in medical zone
        /// </summary>
        public bool InTheMedicalZone { get; set; }
    }
}
