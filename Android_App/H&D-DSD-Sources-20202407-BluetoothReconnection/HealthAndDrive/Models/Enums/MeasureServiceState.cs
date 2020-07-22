
namespace HealthAndDrive.Models.Enums
{
    public enum MeasureServiceState
    {
        /// <summary>
        /// The service is OFF
        /// </summary>
        OFF = 0,

        /// <summary>
        /// The service is waiting for data to come from notifications
        /// </summary>
        WAITING_DATA = 1,

        /// <summary>
        /// The service is receiving data
        /// </summary>
        RECEIVING_DATA = 2,

        /// <summary>
        /// The service refused the last data received
        /// </summary>
        REFUSED_DATA_THEN_WAIT = 3,
    }
}
