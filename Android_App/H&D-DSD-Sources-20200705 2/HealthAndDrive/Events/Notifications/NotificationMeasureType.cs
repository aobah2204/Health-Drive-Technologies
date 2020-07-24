
namespace HealthAndDrive.Events.Notifications
{
    public enum MeasureTrend
    {
        /// <summary>
        /// If there is not trend
        /// </summary>
        None = 0,

        /// <summary>
        /// The glucose measure is increasing heavily
        /// </summary>
        IncreasingHeavy = 1,

        /// <summary>
        /// The glucose measure is increasing
        /// </summary>
        Increasing = 2,

        /// <summary>
        /// The glucose measure is constant
        /// </summary>
        Constant = 3,

        /// <summary>
        /// The glucose measure is decreasing
        /// </summary>
        Decreasing = 4,

        /// <summary>
        /// The glucose measure is decreasing heavily
        /// </summary>
        DecreasingHeavy = 5
    }
}
