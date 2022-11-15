using Entities;
using System.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataCollectionService
{
    internal static class NodeRegistration
    {
        private static string file_name = "D:\\devicelog\\dlog.txt";
        public async static void listener (List<DeviceAttachmentEntity> nodes)
        {
            await Task.Run(() => WriteBuffer(nodes));
        }

        static void WriteBuffer(List<DeviceAttachmentEntity> nodes)
        {
            List<DeviceAttachmentEntity> nodeList = nodes;
            int listenerPort = 55600;
            using (UdpClient udpClient = new UdpClient(listenerPort))
            {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, listenerPort);
                while (true)
                {
                    byte[] buffer = udpClient.Receive(ref iPEndPoint);
                    File.AppendAllText(file_name, System.DateTime.Now.ToLongDateString() + ": " + Encoding.ASCII.GetString(buffer) + Environment.NewLine);
                                        
                    byte[] sendData = Encoding.ASCII.GetBytes("RHC_ACCEPT");
                    udpClient.Send(sendData, iPEndPoint);
                }
            }
        }
    }
}
