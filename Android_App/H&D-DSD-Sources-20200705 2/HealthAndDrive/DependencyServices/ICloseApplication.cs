using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.DependencyServices
{
    /// <summary>
    /// Dependency service used to close application
    /// </summary>
    public interface ICloseApplication
    {
        void closeApplication();
    }
}
