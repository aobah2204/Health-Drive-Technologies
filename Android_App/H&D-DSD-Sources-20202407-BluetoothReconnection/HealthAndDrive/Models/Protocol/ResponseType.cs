using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndDrive.Models.Protocol
{
    public enum PacketResponseType
    {
        /// <summary>
        /// The packet is accepted, we will process it
        /// </summary>
        Accept = 0,

        /// <summary>
        /// The packet needs a specific response
        /// </summary>
        AnswerBack = 1,

        /// <summary>
        /// The packet is refused, an exception will probably be raised
        /// </summary>
        Refuse = 2,

        /// <summary>
        /// The packet is ignored
        /// </summary>
        Ignore = 3
    }
}
