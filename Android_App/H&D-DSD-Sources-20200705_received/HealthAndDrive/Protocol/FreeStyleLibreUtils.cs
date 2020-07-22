﻿using Android.Util;
using HealthAndDrive.Models.Protocol;
using HealthAndDrive.Tools;

namespace HealthAndDrive.Protocol
{
    public class FreeStyleLibreUtils
    {

        public static string LOG_TAG = "FreeStyleLibreUtils";

        /// <summary>
        /// MIAOMIAO PROTOCOL This method determines Freestyle Libre status
        /// </summary>
        /// <param name="sensorStatusByte"></param>
        /// <returns></returns>
        public static bool IsSensorReady(byte sensorStatusByte)
        {
            string SensorStatusString;
            bool ret = false;

            switch (sensorStatusByte)
            {
                case 0x01:
                    SensorStatusString = "not yet started";
                    break;
                case 0x02:
                    SensorStatusString = "starting";
                    ret = true;
                    break;
                case 0x03:          // status for 14 days and 12 h of normal operation, abbott reader quits after 14 days
                    SensorStatusString = "ready";
                    ret = true;
                    break;
                case 0x04:          // status of the following 12 h, sensor delivers last BG reading constantly
                    SensorStatusString = "expired";
                    // @keencave: to use dead sensor for test
                    //            ret = true;
                    break;
                case 0x05:          // sensor stops operation after 15d after start
                    SensorStatusString = "shutdown";
                    // @keencave: to use dead sensors for test
                    //            ret = true;
                    break;
                case 0x06:
                    SensorStatusString = "in failure";
                    break;
                default:
                    SensorStatusString = "in an unknown state";
                    break;
            }
            Log.Debug(MiaoMiaoProtocol.LOG_TAG, "FreeStyleLibreUtils.IsSensorReady: ret=[" + ret + "], SensorStatusString=[" + SensorStatusString + "]");
            return ret;
        }

        /// <summary>
        /// Extract glucose raw value from byte[] data
        /// </summary>
        /// <param name="bytes">The data where the value is encoded</param>
        /// <param name="thirteen">A magic flag that I don't undestand the usage</param>
        /// <returns></returns>
        public static int ExtractGlucoseRaw(byte[] bytes, bool thirteen)
        {
            if (thirteen)
            {
                return (256 * (bytes[0] & 0xff) + (bytes[1] & 0xff)) & 0x1fff;
            }
            else
            {
                return (256 * (bytes[0] & 0xff) + (bytes[1] & 0xff)) & 0x0fff;
            }
        }

        /// <summary>
        /// Generate a RESET packet to be sent to the device
        /// </summary>
        /// <returns>The packet to send</returns>
        public static byte[] GenerateResetPacket()
        {
            byte[] packet = new byte[1];
            packet[0] = 0xf0; // Put in a constant ? 
            return packet;
        }


        public static double ConvertMGDLToMMolPerLiter(AppSettings settings, double mgdl)
        {
            return mgdl * settings.MGDL_TO_MMOLL;
        }

        /// <summary>
        /// This method analyzes the received data and determines what is the behaviour to react (Accept, answer, ignore, refuse)
        /// </summary>
        /// <param name="DialogProtocolHolder">Holds the </param>
        /// <returns></returns>
        public static DialogBehaviourHolder RespondToPacketBehaviour(byte[] packet)
        {
            DialogBehaviourHolder holder = new DialogBehaviourHolder();
            holder.ReceivedData = packet;

            // MIAOMIAO PROTOCOL
            if (packet.Length == 1 && packet[0] == 0x32)
            {
                byte[] resetallowNewSensorValue = new byte[2];
                byte[] frequency = new byte[2];
                byte[] ack = new byte[1];

                // MIAOMIAO PROTOCOL
                resetallowNewSensorValue[0] = 0xD3;
                resetallowNewSensorValue[1] = 0x01;

                frequency[0] = 0xD1;
                frequency[1] = 0x01;

                holder.Response.Add(resetallowNewSensorValue);
                holder.Response.Add(frequency);
                holder.Response.Add(ack);

                holder.ResponseType = PacketResponseType.AnswerBack;

            }

            // MIAOMIAO PROTOCOL
            // received when the Miaomiao is not connected to the sensor
            else if (packet.Length == 1 && packet[0] == 0x34)
            {
                holder.ResponseType = PacketResponseType.Ignore;
            }

            // MIAOMIAO PROTOCOL
            // I don't know what to do with this ==> we will need to raise an error in this case
            // CAUTION : The behaviour should no be PacketResponseType.Ignore in this case 
            else if (packet.Length == 2)
            {
                holder.ResponseType = PacketResponseType.Refuse;
            }

            // MIAOMIAO PROTOCOL
            // The data received is accepted. We will process it
            else
            {
                holder.ResponseType = PacketResponseType.Accept;
            }

            Log.Debug(LOG_TAG, $"FreeStyleLibreUtils.RespondToPacket : answer={holder.ResponseType}");
            return holder;
        }

    }
}
