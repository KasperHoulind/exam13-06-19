using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPbroadcaster
{
    internal class UDPSender
    {

        private Random rnd = new Random();
        public int tonInt()
        {
            return  rnd.Next(1, 4);
        }

        private int _port = 7050;

        public void Start()
        {
            var endPoint = new IPEndPoint(IPAddress.Broadcast, _port);

            using (UdpClient client = new UdpClient())
            {
                while (true)
                {

                    string s001 = $"Sangid * 300 \n {tonInt()} \n {DateTime.Now.ToString()} ";

                    
                    var Byte00 = Encoding.ASCII.GetBytes(s001);
                    client.Send(Byte00, Byte00.Length, endPoint);



                   

                    Console.WriteLine($"Sent \n {s001} to {endPoint.Address}:{endPoint.Port}\n");


                    System.Threading.Thread.Sleep(1000);

                }
            }


        }
    }
}
    
