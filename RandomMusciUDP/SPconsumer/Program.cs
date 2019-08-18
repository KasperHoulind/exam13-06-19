using System;
using RandomMusicRest;

namespace SPconsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumer = new Consumer();

            sangpart sang = new sangpart(123,99,"13:18:55");

            var spList = consumer.GetAllsp();

           

            foreach (var sp in spList)

            Console.WriteLine(sp);


            Console.WriteLine($"forsøger at lave et sangpart obj: {sang}:");
            Console.WriteLine(consumer.Post(sang));
            Console.WriteLine("Printrt opdateret liste ud:");
            foreach (sangpart spobj in consumer.GetAllsp())
            {
                Console.WriteLine(spobj);
            }

            Console.ReadKey();
        }
    }
}
