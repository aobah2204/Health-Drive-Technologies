
namespace HealthAndDrive.Models
{
    using System;
    using Realms;

    /// <summary>
    /// The Sensor model
    /// </summary>
    public class Sensor : RealmObject
    {

        [PrimaryKey]
        public string Id { get; set; }

        /// <summary>
        /// The sensor state
        /// </summary>
        private string state { get; set; }

        /// <summary>
        /// The sensor type 
        /// </summary>
        private string type { get; set; }

        /// <summary>
        /// Gets the sensor state
        /// </summary>
        /// <returns>The sensor state</returns>
        public SensorState GetState()
        {
            return (SensorState)Enum.Parse(typeof(SensorState), state);
        }

        /// <summary>
        /// Sets the sensor state
        /// </summary>
        /// <param name="state">The state to set</param>
        public void SetState(SensorState state) 
        {
            this.state = state.ToString();
        }

        /// <summary>
        /// Gets the sensor type
        /// </summary>
        /// <returns>The sensor type</returns>
        public SensorType GetSensorType()
        {
            return (SensorType)Enum.Parse(typeof(SensorType), type);
        }

        /// <summary>
        /// Sets the sensor type
        /// </summary>
        /// <param name="type">The type to set</param>
        public void SetType(SensorType type)
        {
            this.type = type.ToString();
        }

        /// <summary>
        /// Indicates if the sensor is deleted or not
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The sensor age
        /// </summary>
        public long Age { get; set; } = -1;

    }

}
