using Realms;
using System;
using System.Text;

namespace HealthAndDrive.Models
{
    public class GlucoseMeasure :  RealmObject, IComparable<GlucoseMeasure>
    {

        [PrimaryKey] 
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the sensor time
        /// </summary>
        public long SensorTime { get; set; }

        /// <summary>
        /// Gets or sets the SensorId
        /// </summary>
        public String SensorId { get; set; }

        /// <summary>
        /// Gets or sets the UserId
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// Gets or sets the measure timestamp
        /// </summary>
        public long Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the Real measure date
        /// </summary>
        public DateTimeOffset RealDateTimeOffset { get; set; }

        /// <summary>
        /// Gets or sets the Glucose level (in MGDL)
        /// </summary>
        public float GlucoseLevelMGDL { get; set; }

        /// <summary>
        /// Gets or sets the Glucose level (in MMOL)
        /// </summary>
        public float GlucoseLevelMMOL { get; set; }

        /// <summary>
        /// Gets or sets the Glucose raw level
        /// </summary>
        public float GlucoseLevelRaw { get; set; }

        /// <summary>
        /// Gets or sets the Glucose level raw smoothed
        /// </summary>
        public float GlucoseLevelRawSmoothed { get; set; }

        /// <summary>
        /// /Gets or sets the Glucose offset
        /// </summary>
        public float CalibrationOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool InTheMedicalZone { get; set; }

        public GlucoseMeasure()
        {
            this.GlucoseLevelMGDL = -1;
            this.GlucoseLevelMMOL = -1;
            this.GlucoseLevelRaw = -1;
            this.InTheMedicalZone = true;
            this.CalibrationOffset = 0;
        }

        public int CompareTo(GlucoseMeasure other)
        {
            return (int)(RealDateTimeOffset.Millisecond - other.RealDateTimeOffset.Millisecond);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            return builder.
                Append("RealDateTimeOffset=[" + RealDateTimeOffset.LocalDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "], ")
                .Append("Timestamp[" + Timestamp + "], ")
                .Append("GlucoseLevelRaw=[" + GlucoseLevelRaw + "], ")
                .Append("GlucoseLevelMGDL=[" + GlucoseLevelMGDL + "], ")
                .Append("GlucoseLevelMMOL=[" + GlucoseLevelMMOL + "], ")
                .Append("CalibrationOffset=[" + CalibrationOffset + "], ")
                .ToString();
        }
    }
}
