
namespace HealthAndDrive.Models
{
    using HealthAndDrive.Events.Notifications;
    using Realms;
    using System;

    /// <summary>
    /// The user model  
    /// </summary>
    public class User : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.Parse("deadbeef-cafe-babe-cafe-babecafebabe").ToString();

        /// <summary>
        /// Gets or sets the picture url
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the user full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The UUID of the device associated to the user
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// The device name associated to the user
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// The offset resulting from the calibration
        /// </summary>
        public double MeasureOffset { get; set; }

        /// <summary>
        /// The current measure for the user
        /// </summary>
        public float CurrentMeasure { get; set; }

        /// <summary>
        /// Are alert activated for the user
        /// </summary>
        public bool IsAlert { get; set; }

        /// <summary>
        /// Average glycemia for the user
        /// </summary>
        public float AverageGlycemia { get; set; }

        /// <summary>
        /// Average measures in the medical zone
        /// </summary>
        public float AverageInTheMedicalZone { get; set; }

        /// <summary>
        /// The HBA1C value
        /// </summary>
        public float HBA1C { get; set; }

        /// <summary>
        /// Is Floating Widget enable for the user
        /// </summary>
        public bool IsWidgetEnable { get; set; }

        /// <summary>
        /// This methods determines if a device is bounded
        /// </summary>
        public bool DeviceIsBounded
        {
            get
            {
                bool test = !String.IsNullOrEmpty(this.DeviceId) || !String.IsNullOrEmpty(this.DeviceName);
                return test;
            }
        }

        /// <summary>
        /// The last measure scanned
        /// </summary>
        public DateTimeOffset LastMeasureTimeStamp { get; set; }

        /// <summary>
        /// The miaomiao current battery percent
        /// </summary>
        public int CurrentBatteryPercent { get; set; }

        /// <summary>
        /// The measure trend
        /// </summary>
        public string CurrentMeasureTrend { get; set; }

        /// <summary>
        /// The saved widget x position
        /// </summary>
        public int WidgetPositionX { get; set; }

        /// <summary>
        /// The saved widget y position
        /// </summary>
        public int WidgetPositionY { get; set; }

        /// <summary>
        /// Gets the measure trend
        /// </summary>
        /// <returns>The sensor type</returns>
        public MeasureTrend GetMeasureTrend()
        {
            return CurrentMeasureTrend != null
                ? (MeasureTrend)Enum.Parse(typeof(MeasureTrend), CurrentMeasureTrend)
                : MeasureTrend.None;
        }

        /// <summary>
        /// Sets the measure trend
        /// </summary>
        /// <param name="type">The type to set</param>
        public void SetMeasureTrend(MeasureTrend trend)
        {
            this.CurrentMeasureTrend = trend.ToString();
        }
    }
}
