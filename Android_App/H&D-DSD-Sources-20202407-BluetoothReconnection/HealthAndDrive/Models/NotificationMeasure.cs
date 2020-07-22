using HealthAndDrive.Events.Notifications;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Models
{
    public class NotificationMeasure
    {

        public NotificationMeasure()
        {

        }

        public NotificationMeasure(NotificationMeasure source)
        {
            this.MeasureTrend = source.MeasureTrend;
            this.NewMeasure = source.NewMeasure;
            this.NotificationMessage = source.NotificationMessage;
            this.MinimumGlucoseTreshold = source.MinimumGlucoseTreshold;
            this.MaximumGlucoseTreshold = source.MaximumGlucoseTreshold;
            this.ColorValue = source.ColorValue;
            this.IsAlert = source.IsAlert;
            this.NotificationMeasureDate = source.NotificationMeasureDate;
        }

        /// <summary>
        /// Tendance de la valeur
        /// </summary>
        public MeasureTrend MeasureTrend { get; set; }

        /// <summary>
        /// Nouvelle valeur
        /// </summary>
        public float NewMeasure { get; set; }

        /// <summary>
        /// Texte de notifiaction
        /// </summary>
        public string NotificationMessage { get; set; }

        /// <summary>
        /// Valeur mini pour les alertes
        /// </summary>
        public int MinimumGlucoseTreshold { get; set; }

        /// <summary>
        /// Valeur max pour les alertes
        /// </summary>
        public int MaximumGlucoseTreshold { get; set; }

        /// <summary>
        /// Couleur à afficher en fonction du glucose
        /// </summary>
        public string ColorValue { get; set; }

        /// <summary>
        /// Indique si les alarmes sont actives ou non
        /// </summary>
        public bool IsAlert { get; set; }

        /// <summary
        /// Last mesure date
        /// </summary>
        public DateTimeOffset NotificationMeasureDate { get; set; }

    }
}
