
namespace HealthAndDrive.Protocol
{
    public interface IProtocol
    {
        /// <summary>
        /// The device name 
        /// </summary>
        /// <returns>The device name</returns>
        string GetDeviceName();

        /// <summary>
        /// The UUID of the service we need to read and write
        /// </summary>
        /// <returns>The UUID of the service</returns>
       string GetServiceUUID();

        /// <summary>
        /// The UUID of the RX characteristic
        /// </summary>
        /// <returns>The UUID of the RX characs</returns>
        string GetRXCharacteristicUUID();

        /// <summary>
        /// The UUID of the TX characteristic
        /// </summary>
        /// <returns>The UUID of the TX characs</returns>
        string GetTxCharacteristicUUID();

        /// <summary>
        /// PRocess the packet (decoding, extracting values, creating models)
        /// </summary>
        /// <param name="packet">The acket received by the notification and to be decoded</param>
        void ProcessPacket(byte[] packet);

    }
}
