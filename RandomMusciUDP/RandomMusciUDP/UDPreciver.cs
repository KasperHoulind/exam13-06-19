using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RandomMusciUDP
{
    public class UDPreciver
    {
       double Sangid;
       int Tone;
       DateTime Tid;
        
        
        private int _port = 7050;
        public void Start()
        {
            Console.WriteLine("Wating for data...\n");

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);


            using (UdpClient clinet = new UdpClient(_port))
            {
                while (true)
                {
                    HandleClient(clinet, endPoint);

                }
            }

        }

        private void HandleClient(UdpClient client, IPEndPoint endPoint)
        {
            byte[] data = client.Receive(ref endPoint);
            string dataStr = Encoding.ASCII.GetString(data);


            //splitting of byte array below.

            string[] textLines = dataStr.Split('\n');

            



           string[] list1 = textLines[0].Split('*'); // looks at specifed postion in the byte array this case its postion 3
           string text1 = list1[1];
           //string[] list2 = textLines[1].Split('*');
           //string text2 = list2[0];
           string[] list3 = textLines[2].Split('*');
           string text3 = list3[0];


            //Sangid = Double.Parse(text1.Trim()); // trim to avoid whitespace and messy text 
           // Tone = Int32.Parse(text2.Trim());
           // Tid = DateTime.Parse(text3.Trim());
          


            Console.WriteLine($"DATA Recived \n {dataStr}\n from {endPoint.Address}:{endPoint.Port}");

            Console.WriteLine("Data being splitted to idvidual values below\n");

            Console.WriteLine($" first split string - Sangid is {text1}\n");
            //Console.WriteLine($" Second split string - Tid is {text2}\n");
            Console.WriteLine($" Thirs split string - Tid is {text3}\n");
        }
    }
}
    
