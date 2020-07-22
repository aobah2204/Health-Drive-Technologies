using HealthAndDrive.Models;
using HealthAndDrive.RepositoryContracts;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthAndDrive.Repositories
{
    public class UserSettingsRepository : IUserSettingsRepository
    {

        /// <summary>
        /// Access to the realm database
        /// </summary>
        private readonly Realm realm;

        /// <summary>
        /// Initializes a new instance of the class <see cref="UserRepository"/>.
        /// </summary>
        /// <param name="realm"></param>
        public UserSettingsRepository(Realm realm)
        {
            this.realm = realm;

            if (!this.realm.All<UserSettings>().Any())
            {
                this.realm.Write(() =>
                {
                    this.realm.Add(new UserSettings
                    {
                        CalibrationSourcedValue = 0,
                        CalibrationRevisedValue = 0,
                        MeasureOffset = 0,
                        MinimumGlucoseTreshold = 70,
                        MaximumGlucoseTreshold = 200
                    });
                });
            }
        }

        /// <summary>
        /// This method change the sensor calibration values
        /// </summary>
        /// <param name="sourcedValue">The calibration source values (measured by the sensor)</param>
        /// <param name="revisedValue">The calibration revised (measured by the user by another way)</param>
        public void UpdateSensorCalibration(UserSettings entity, float sourcedValue, float revisedValue)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.CalibrationSourcedValue = sourcedValue;
                entity.CalibrationRevisedValue = revisedValue;
                entity.MeasureOffset += revisedValue - sourcedValue;
                trans.Commit();
            }
        }

        /// <summary>
        /// Get the current user settings
        /// </summary>
        /// <returns></returns>
        public UserSettings GetCurrentUserSettings()
        {
            return this.realm.All<UserSettings>().FirstOrDefault();
        }

        /// <summary>
        /// Update maximum glucose treshold
        /// </summary>
        public void UpdateMaximumGlucoseTreshold(UserSettings entity, int value)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.MaximumGlucoseTreshold = value;
                trans.Commit();
            }
        }

        /// <summary>
        /// Update minimum glucose treshold
        /// </summary>
        public void UpdateMinimumGlucoseTreshold(UserSettings entity, int value)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.MinimumGlucoseTreshold = value;
                trans.Commit();
            }
        }
    }
}
