using System;

namespace UDPbroadcaster
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new UDPSender();
            s.Start();
            Console.ReadKey();
        }
    }
}
