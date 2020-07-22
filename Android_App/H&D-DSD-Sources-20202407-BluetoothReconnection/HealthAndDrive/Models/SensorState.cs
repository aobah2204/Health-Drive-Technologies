
namespace HealthAndDrive.Models
{
    /// <summary>
    /// This enum describes the sensor states
    /// </summary>
    public enum SensorState
    {
        // The sensor is not started (what is the difference between NotStarted and shutdown
        NotStarted = 0, 

        // The sensor is starting
        Starting = 1,

        // The sensor is ready
        Ready = 2,

        // The sensor has expired
        Expired = 3,
        
        // The sensor is shutdown
        Shutdown = 4,

        // The sensor is in failure
        InFailure = 5,

        // The sensor is in unknown state
        Unknown = 6
    }
}