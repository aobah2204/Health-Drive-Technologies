using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Models.Protocol
{
    public class DialogBehaviourHolder
    {
        /// <summary>
        /// Gets or sets the response type
        /// </summary>
        public PacketResponseType ResponseType { get; set; }

        /// <summary>
        /// Gets or sets the received data
        /// </summary>
        public byte[] ReceivedData { get; set; }

        /// <summary>
        /// Gets or sets our data answer
        /// </summary>
        public List<byte[]> Response { get; set; }

        public DialogBehaviourHolder()
        {
            this.Response = new List<byte[]>();
        }
    }
}