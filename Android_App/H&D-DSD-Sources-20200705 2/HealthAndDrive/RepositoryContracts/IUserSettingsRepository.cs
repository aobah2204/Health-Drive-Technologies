using HealthAndDrive.Models;

namespace HealthAndDrive.RepositoryContracts
{
    public interface IUserSettingsRepository
    {     
        /// <summary>
        ///  Gets the current user settings (only one item in the H&D MVP)
        /// </summary>
        /// <returns>The current user setting</returns>
        UserSettings GetCurrentUserSettings();

        /// <summary>
        /// Update maximum glucose treshold
        /// </summary>
        void UpdateMaximumGlucoseTreshold(UserSettings settings, int maxValue);

        /// <summary>
        /// Update minimum glucose treshold
        /// </summary>
        void UpdateMinimumGlucoseTreshold(UserSettings settings, int minValue);

        /// <summary>
        /// This method change the sensor calibration values
        /// </summary>
        /// <param name="entity">The entity to be set</param>
        /// <param name="CalibrationSourcedValue">The calibration source values (measured by the sensor)</param>
        /// <param name="CalibrationRevisedValue">The calibration revised (measured by the user by another way)</param>
        void UpdateSensorCalibration(UserSettings entity, float CalibrationSourcedValue, float CalibrationRevisedValue);
    }
}
