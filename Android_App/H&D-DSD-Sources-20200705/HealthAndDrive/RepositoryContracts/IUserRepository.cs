
namespace HealthAndDrive.RepositoryContracts
{
    using HealthAndDrive.Events.Notifications;
    using HealthAndDrive.Models;
    using System;

    public interface IUserRepository
    {
        /// <summary>
        /// This method changes the user name
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="newName">The neww name value</param>
        User GetCurrentUser();

        /// <summary>
        /// This method changes the user name
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="newName">The neww name value</param>
        void ChangeName(User entity, string newName);

        /// <summary>
        /// This method registers a device information for a user
        /// </summary>
        /// <param name="entity">The entity to be set</param>
        /// <param name="deviceID">The device unique identifier</param>
        /// <param name="deviceName">The device name</param>
        void RegisterDevice(User entity, string deviceID, string deviceName);

        /// <summary>
        /// This method unregisters device informations for a user
        /// </summary>
        /// <param name="entity">The entity to be set</param>
        void UnregisterDevice(User entity);


        /// <summary>
        /// This method changes the user alerts
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="isActive">The value</param>
        void ChangeIsAlarm(User entity, bool isActive);

        /// <summary>
        /// Changes the current glucose measure for a user
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="measure">The current measure</param>
        void ChangeCurrentMeasure(User entity, float measure);

        /// <summary>
        /// Changes the user average glycemia
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="average">The average value to set</param>
        void ChangeAverageGlycemia(User entity, float average);

        /// <summary>
        /// Changes the user average measures in the medical zone
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="average">The average value to set</param>
        void ChangeAverageInTheMedicalZone(User entity, float average);

        /// <summary>
        /// Changes the user HBA1C
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="average">The value to set</param>
        void ChangeHBA1C(User entity, float average);

        /// <summary>
        /// Update the module battery percentage
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="percentage"></param>
        void UpdateDeviceBatteryPercentage(User entity, int percentage);

        /// <summary>
        /// Update the last time that value has been updated
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lastCheck"></param>
        void UpdateLastValueTimeStamp(User entity, DateTimeOffset lastCheck);

        /// <summary>
        /// Save the current trend
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="trend"></param>
        void UpdateMeasureTrend(User entity, MeasureTrend trend);

        /// <summary>
        /// Changes the user floating widget flag
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="isWidgetEnable">The value to set</param>
        void ChangeIsWidgetEnable(User entity, bool isWidgetEnable);

        /// <summary>
        /// Save the x widget position
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="x"></param>
        void UpdateWidgetPositionX(User entity, int x);

        /// <summary>
        /// Save the y widget position
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="y"></param>
        void UpdateWidgetPositionY(User entity, int y);
    }
}
