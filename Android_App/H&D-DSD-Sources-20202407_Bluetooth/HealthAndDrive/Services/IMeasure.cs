using HealthAndDrive.Events.Notifications;
using HealthAndDrive.Models;
using HealthAndDrive.Models.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAndDrive.Services
{
    public interface IMeasure
    {
        /// <summary>
        /// Gets the current service state
        /// </summary>
        /// <returns>The service</returns>
        MeasureServiceState CurrentState();

        /// <summary>
        /// Register the bluetooth device and connects to it
        /// </summary>
        /// <param name="device">The device to register</param>
        /// <returns>True if the registration is successfull. False in any other case</returns>
        Task<bool> RegisterDeviceAsync(Device device);

        /// <summary>
        /// Register the bluetooth device and disconnects from it
        /// </summary>
        /// <param name="device">The device to register</param>
        /// <returns>True if the unregistration is successfull. False in any other case</returns>
        void UnregisterDevice(Device device);

        /// <summary>
        /// Initializes a ble service within the device
        /// </summary>
        /// <param name="device">The device to initialize</param>
        /// <param name="serviceUUID">The service to initialize</param>
        /// <returns>True if the intialization is successfull. False in any other case</returns>
        Task<bool> InitializeBLEServicesAsync(Device device, string serviceUUID);

        /// <summary>
        /// Subscribes to a characteristic change.
        /// This method should be called (at least) after IMeasure.InitializeBLEServicesAsync 
        /// </summary>
        /// <param name="characteristicUUID">The characteristic UUID to subscribe</param>
        /// <returns>True if the subscription is successfull. False in any other case</returns>
        Task<bool> SubsrcibeCharacteristicAsync(string characteristicUUID);

        /// <summary>
        /// Read a characteristic and write an intializes
        /// </summary>
        /// <param name="characteristicUUID">The characteristic UUID to write</param>
        /// /// <param name="values">The values to write</param>
        /// <returns></returns>
        Task<bool> WriteCharacteristicAsync(string characteristicUUID, List<byte[]> values);

        /// <summary>
        /// Pushes a notification measure for the user 
        /// </summary>
        /// <param name="message">The message to notify</param>
        void PushMeasureNotification(NotificationMeasure message);

        /// <summary>
        /// Pushes a notification alert for the user
        /// </summary>
        /// <param name="message">The message to notify</param>
        void PushAlertNotification(NotificationMeasure message);

    }
}
