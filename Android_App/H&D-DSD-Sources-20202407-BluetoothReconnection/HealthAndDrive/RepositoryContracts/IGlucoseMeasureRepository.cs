
namespace HealthAndDrive.RepositoryContracts
{
    using HealthAndDrive.Models;
    using HealthAndDrive.Tools;
    using System.Collections.Generic;

    public interface IGlucoseMeasureRepository
    {
        /// <summary>
        /// Get a measure for a given timestamp, sensorId, userId
        /// NOTE : 
        ///     For the H&D MVP, the user will always be the same.
        ///     MiaoMiao Protocol : The Freestyle14 sensor has a lifetime of 14 days.
        ///     After a change, the sensortime starts over.
        ///     THe "primary key is representated by the composition of sensorTime | sensorId | userId
        /// </summary>
        /// <param name="sensorTime">The sensor time</param>
        /// <param name="sensorId">The sensorId</param>
        /// <param name="userId">The userId</param>
        /// <returns></returns>
        GlucoseMeasure GetMeasureByTimestampSensorIdAndUser(long sensorTime, string sensorId, string userId);

        /// <summary>
        /// Returns the last GlucoseMeasure for a user
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <returns></returns>
        GlucoseMeasure GetLastMeasureByUser(string userId);

        /// <summary>
        /// Determines if a measure exists or not
        /// </summary>
        /// <param name="timestamp">The measure timestamp</param>
        /// <param name="sensorId">The sensorId</param>
        /// <param name="userId">The userId</param>
        /// <returns>True if the measure exists. False in other case</returns>
        bool Exists(long timestamp, string sensorId, string userId);

        /// <summary>
        /// Creates a GlucoseMeasure
        /// </summary>
        /// <param name="entity">The measure to create</param>
        /// <param name="userId">The UserId</param>
        void Create(GlucoseMeasure entity, string userId);

        /// <summary>
        /// Returns the full list of GlucoseMeasure for a user 
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <returns></returns>
        List<GlucoseMeasure> GetAllMeasuresByUser(string userId);

        /// <summary>
        /// Returns the list of GlucoseMeasure for a user. 
        /// The list is limited to the measures of the past 24 hours
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <returns></returns>
        List<GlucoseMeasure> GetLastDayMeasuresByUser(string userId);

        /// <summary>
        /// Returns the list of GlucoseMeasure for a user. 
        /// The list is limited to the measures of the past week
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <returns></returns>
        List<GlucoseMeasure> GetLastWeekMeasuresByUser(string userId);

        /// <summary>
        /// Returns the list of GlucoseMeasure for a user. 
        /// The list is limited to the measures of the 15 past days 
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <returns></returns>     
        List<GlucoseMeasure> GetLastHalfMonthMeasuresByUser(string userId);

        /// <summary>
        /// Returns the list of GlucoseMeasure for a user. 
        /// The list is limited to the measures of the past month
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <returns></returns>
        List<GlucoseMeasure> GetLastMonthMeasuresByUser(string userId);

        /// <summary>
        /// Returns the list of GlucoseMeasure from the last 60  minutes
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<GlucoseMeasure> GetLastSixtyMinutesMeasuresByUser(string userId);

        /// <summary>
        /// Returns the GlucoseMeasure from the last past 15 minutes
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        GlucoseMeasure GetPastFifteenMinutesMeasureByUser(string userId);

        /// <summary>
        /// Remove all the GlucoseMeasure in the database
        /// </summary>
        void RemoveAll();

        /// <summary>
        /// Counts all the GlucoseMeasure for a given user
        /// </summary>
        /// <param name="userId">The userId</param>
        /// <returns></returns>
        long CountByUser(string userId);

        /// <summary>
        /// Gets the average of measures in the medical zone
        /// NOTE : Average and Sum functions is not supported in REALM (https://realm.io/docs/dotnet/0.81.0/api/md_linq-support.html)
        /// So we have to do it "by hand"
        /// </summary>
        /// <param name="userId">The user to filter</param>
        /// <returns>The average measure</returns>
        float GetAverageInTheZone(string userId);

        /// <summary>
        /// Gets the average of glycemia for a user
        /// NOTE : Average and Sum functions is not supported in REALM (https://realm.io/docs/dotnet/0.81.0/api/md_linq-support.html)
        /// So we have to do it "by hand"
        /// </summary>
        /// <param name="userId">The user to filter</param>
        /// <returns>The average measure</returns>
        float GetAverageGlycemia(string userId);

        /// <summary>
        /// Update the measure offset for a GlucoseMeasure
        /// </summary>
        /// <param name="measure">The measure to update</param>
        /// <param name="offsetValue">The offset value coming from the calibration</param>
        /// <param name="appSettings">The appSettings</param>
        GlucoseMeasure UpdateMeasureOffset(GlucoseMeasure measure, float calibrationOffset, AppSettings appSettings);

        /// <summary>
        /// Update the userId measure for a glucose measure
        /// </summary>
        /// <param name="measure"></param>
        /// <param name="userId"></param>
        void ChangeUserId(GlucoseMeasure measure, string userId);

        /// <summary>
        /// Update the userId measure for a glucose measure
        /// </summary>
        /// <param name="measure"></param>
        /// <param name="isInTheMedicalZone"></param>
        void ChangeIsInTheMedicalZone(GlucoseMeasure measure, bool isInTheMedicalZone);

    }
}
