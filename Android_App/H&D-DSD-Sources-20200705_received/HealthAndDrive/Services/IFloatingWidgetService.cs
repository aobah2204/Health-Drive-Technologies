using System;

namespace HealthAndDrive.Services
{
    public interface IFloatingWidgetService
    {
        bool IsEnable { get; set; }

        event EventHandler IsWidgetEnabled;
    }
}
