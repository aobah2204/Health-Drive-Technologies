using Realms;

namespace HealthAndDrive.Models
{
    public class UserSettings : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        /// <summary>
        /// The value measured by MiaoMiao
        /// </summary>
        public float CalibrationSourcedValue { get; set; }

        /// <summary>
        /// The value revised by the user
        /// </summary>
        public float CalibrationRevisedValue { get; set; }

        /// <summary>
        /// The offset resulting from the calibration
        /// </summary>
        public float MeasureOffset { get; set; }

        /// <summary>
        /// Are alert activated for the user
        /// </summary>
        public bool IsAlert { get; set; }

        /// <summary>
        /// The minimum glucose treshold value
        /// </summary>
        public int MinimumGlucoseTreshold { get; set; }

        /// <summary>
        /// The maximum glucose treshold value
        /// </summary>
        public int MaximumGlucoseTreshold { get; set; }

    }
}
