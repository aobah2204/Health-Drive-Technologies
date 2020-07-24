
namespace HealthAndDrive.Models.Enums
{
    public enum ProtocolState
    {
        /// <summary>
        /// Wait for data to come from notifications
        /// </summary>
        WAITING_DATA_CHANGE = 0,

        /// <summary>
        /// Data has been sent to the device (only for initialization)
        /// </summary>
        REQUEST_DATA_SENT = 1,

        /// <summary>
        /// Data is being received by 
        /// </summary>
        RECEIVING_DATA = 2
    }
}
