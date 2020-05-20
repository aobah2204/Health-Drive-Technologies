using System.Collections.Generic;
using System.Linq;
using HealthAndDrive.Models;
using HealthAndDrive.RepositoryContracts;
using Realms;

namespace HealthAndDrive.Repositories
{
    /// <summary>
    /// The class is a user repository and allows to access sensor data
    /// </summary>
    public class SensorRepository : ISensorRepository
    {
        /// <summary>
        /// Access to the realm database
        /// </summary>
        private readonly Realm realm;

        /// <summary>
        /// INitializes a new instance of the class <see cref="SensorRepository"/>.
        /// </summary>
        /// <param name="realm"></param>
        public SensorRepository(Realm realm)
        {
            this.realm = realm;
        }

        /// <summary>
        /// Gets a Sensor by his Id
        /// </summary>
        /// <param name="id">The id to found</param>
        /// <returns></returns>
        public Sensor GetById(string id)
        {
           return this.realm.All<Sensor>().FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Checks if a Sensor exists in the DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if the sensor exists, False in oher cases</returns>
        public bool Exists(string id)
        {
            Sensor sensor = this.realm.All<Sensor>().FirstOrDefault(s => s.Id == id);
            return sensor != null;
        }        

        /// <summary>
        /// Get the current active sensor (IsDeleted = false)
        /// </summary>
        /// <returns></returns>
        public Sensor GetCurrentSensor()    
        {
            // The sensor to be selected 
            return this.realm.All<Sensor>().FirstOrDefault(s => s.IsDeleted == false);
        }

        /// <summary>
        /// Removes (soft delete) a sensor
        /// </summary>
        /// <param name="id">The sensor id to soft delete</param>
        public void Remove(Sensor toDelete)
        {
            using (var trans = realm.BeginWrite())
            {
                toDelete.IsDeleted = true;
                trans.Commit();
            }
        }

        /// <summary>
        /// Get all the sensors
        /// </summary>
        /// <returns>The list of ther sensors found</returns>v
        public List<Sensor> GetAll()
        {
            // The sensor to be selected 
            return this.realm.All<Sensor>().ToList();
        }

        /// <summary>
        /// Registers a new Sensor
        /// </summary>
        /// <param name="entity">The new Sensor to register</param>
        public void RegisterNewSensor(Sensor entity)
        {
            entity.SetState(SensorState.Ready);

            // For the MVP, only FreestyleLibre14
            entity.SetType(SensorType.FreestyleLibre14);
            entity.IsDeleted = false;

            this.realm.Write(() =>
            {
                this.realm.Add(entity);
            });
        }

        /// <summary>
        /// Updates the age of a given sensor
        /// </summary>
        /// <param name="entity">The entity to be updated</param>
        /// <param name="age">The age of the sensor</param>
        public void UpdateSensorAge(Sensor entity, long age)
        {
            using (var trans = realm.BeginWrite())
            {
                entity.Age = age;
                trans.Commit();
            }
        }
    }
}
