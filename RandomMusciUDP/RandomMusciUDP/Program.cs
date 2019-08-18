using System;

namespace RandomMusciUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new UDPreciver();
            r.Start();
            Console.ReadKey();
        }
    }
}
