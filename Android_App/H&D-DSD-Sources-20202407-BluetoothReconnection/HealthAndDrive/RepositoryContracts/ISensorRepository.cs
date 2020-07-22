
namespace HealthAndDrive.RepositoryContracts
{
    using HealthAndDrive.Models;
    using System.Collections.Generic;

    public interface ISensorRepository
    {
        /// <summary>
        /// Gets the current active sensor
        /// </summary>
        /// <returns></returns>
        Sensor GetCurrentSensor();

        /// Gets a Sensor by his Id
        /// </summary>
        /// <param name="id">The id to found</param>
        /// <returns></returns>
        Sensor GetById(string id);

        /// <summary>
        /// Add a new sensor to the DB
        /// </summary>
        /// <param name="entity"></param>
        void RegisterNewSensor(Sensor entity);

        /// <summary>
        /// Removes the indicated sensor
        /// </summary>
        /// <param name="entity">The entity fo "remove"</param>
        void Remove(Sensor entity);

        /// <summary>
        /// Checks if a Sensor exists in the DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if the sensor exists, False in oher cases</returns>
        bool Exists(string id);

        /// <summary>
        /// Get all the sensors
        /// </summary>
        /// <returns>The list of ther sensors found</returns>
        List<Sensor> GetAll();

        /// <summary>
        /// Updates the age of a given sensor
        /// </summary>
        /// <param name="entity">The entity to be updated</param>
        /// <param name="age">The age of the sensor</param>
        void UpdateSensorAge(Sensor entity, long age);
    }
}
