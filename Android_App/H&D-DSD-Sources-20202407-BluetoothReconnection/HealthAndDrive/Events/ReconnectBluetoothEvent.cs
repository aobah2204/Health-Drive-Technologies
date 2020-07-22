using System;
using Prism.Events;

namespace HealthAndDrive.Events
{
    public class ReconnectBluetoothEvent : PubSubEvent<string>
    {
        public ReconnectBluetoothEvent()
        {
        }
    }
}
