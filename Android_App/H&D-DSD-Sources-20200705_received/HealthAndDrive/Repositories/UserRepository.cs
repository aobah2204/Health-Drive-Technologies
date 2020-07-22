using HealthAndDrive.Events.Notifications;
using HealthAndDrive.Models;
using HealthAndDrive.RepositoryContracts;
using Realms;
using System;
using System.Linq;

namespace HealthAndDrive.Repositories
{
    /// <summary>
    /// The class is a user repository and allows to access user data
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Access to the realm database
        /// </summary>
        private readonly Realm realm;

        /// <summary>
        /// Initializes a new instance of the class <see cref="UserRepository"/>.
        /// </summary>
        /// <param name="realm"></param>
        public UserRepository(Realm realm)
        {
            this.realm = realm;

            if (!this.realm.All<User>().Any())
            {
                this.realm.Write(() =>
                {
                    this.realm.Add(new User
                    {
                        FullName = "Sylvia Claes"
                    });
                });
            }
        }

        /// <summary>
        /// This method retrieve the current (and only) user in the database 
        /// NOTE : For the H&D MVP, only one user per database
        /// </summary>
        /// <returns>The user </returns>
        public User GetCurrentUser()
        {
            return this.realm.All<User>().FirstOrDefault();
        }

        /// <summary>
        /// This method changes the user name
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="newName">The neww name value</param>
        public void ChangeName(User entity, string newName)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.FullName = newName;
                trans.Commit();
            }
        }

        /// <summary>
        /// This method changes the user alerts
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="isActive">The value</param>
        public void ChangeIsAlarm(User entity, bool isActive)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.IsAlert = isActive;
                trans.Commit();
            }
        }

        /// <summary>
        /// This method registers a device information for a user
        /// </summary>
        /// <param name="entity">The entity to be set</param>
        /// <param name="deviceID">The device unique identifier</param>
        /// <param name="deviceName">The device name</param>
        public void RegisterDevice(User entity, string deviceID, string deviceName)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.DeviceId = deviceID;
                entity.DeviceName = deviceName;
                trans.Commit();
            }
        }

        /// <summary>
        /// This method unregisters device informations for a user
        /// </summary>
        /// <param name="entity"></param>
        public void UnregisterDevice(User entity)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.DeviceId = null;
                entity.DeviceName = null;
                entity.MeasureOffset = 0;
                trans.Commit();
            }
        }

        /// <summary>
        /// Simply updates a full user
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="measure">The current measure</param>
        public void ChangeCurrentMeasure(User entity, float measure)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.CurrentMeasure = measure;
                trans.Commit();
            }
        }

        /// <summary>
        /// Changes the user average glycemia
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="average">The average value to set</param>
        public void ChangeAverageGlycemia(User entity, float average)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.AverageGlycemia = average;
                trans.Commit();
            }
        }

        /// <summary>
        /// Changes the user average measures in the medical zone
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="average">The average value to set</param>
        public void ChangeAverageInTheMedicalZone(User entity, float average)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.AverageInTheMedicalZone = average;
                trans.Commit();
            }
        }

        /// <summary>
        /// Changes the user HBA1C
        /// </summary>
        /// <param name="entity">The user to update</param>
        /// <param name="average">The value to set</param>
        public void ChangeHBA1C(User entity, float value)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.HBA1C = value;
                trans.Commit();
            }
        }
        /// <summary>
        /// Update the device battery percentage
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="percentage"></param>
        public void UpdateDeviceBatteryPercentage(User entity, int percentage)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.CurrentBatteryPercent = percentage;
                trans.Commit();
            }
        }

        /// <summary>
        /// Update the last value time stamp
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lastCheck"></param>
        public void UpdateLastValueTimeStamp(User entity, DateTimeOffset lastCheck)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.LastMeasureTimeStamp = lastCheck;
                trans.Commit();
            }
        }

        /// <summary>
        /// Update the measure trend
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="trend"></param>
        public void UpdateMeasureTrend(User entity, MeasureTrend trend)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.SetMeasureTrend(trend);
                trans.Commit();
            }
        }
        /// <summary>
        /// This method changes the widget active flag
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="isWidgetEnable">The value</param>
        public void ChangeIsWidgetEnable(User entity, bool isWidgetEnable)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.IsWidgetEnable = isWidgetEnable;
                trans.Commit();
            }
        }

        /// <summary>
        /// This method saves the x widget position
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="isWidgetEnable">The value</param>
        public void UpdateWidgetPositionX(User entity, int x)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.WidgetPositionX = x;
                trans.Commit();
            }
        }


        /// <summary>
        /// This method saves the x widget position
        /// </summary>
        /// <param name="entity">The entity to modified</param>
        /// <param name="isWidgetEnable">The value</param>
        public void UpdateWidgetPositionY(User entity, int y)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.WidgetPositionY = y;
                trans.Commit();
            }
        }
    }
}
