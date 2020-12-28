using Laptop.Graphics;
using Laptop.Processor;
using Laptop.Ram;
using Laptop.SSD;
using System;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Da se podobri ovoj kod. Da se napravi nasleduvanje kade sto e mozno i da se dodadat properties

            IRam ram1 = new Corsair(3200);
            IRam ram2 = new Kingston(2666);

            IProcessor processor1 = new Intel() { Ghz = 3.2f };
            IProcessor processor2 = new Intel() { Ghz = 2.8f };
            IProcessor processor3 = new AMD() { Ghz = 5.0f };

            ISSD ssd1 = new Samsung() { Capacity = 512 };
            ISSD ssd2 = new WD() { Capacity = 512 };
            ISSD ssd3 = new Samsung() { Capacity = 256 };

            IGraphics graphisc1 = new Nvidia() { Gb = 4 };


            Laptop laptop1 = new Dell(processor2, ram2, ssd3, graphisc1);
            Laptop laptop2 = new Dell(processor3, ram1, ssd2, graphisc1);
            Laptop laptop3 = new Asus(processor1, ram2, ssd1, graphisc1);

            Console.WriteLine("------------------- Laptop1 ---------------------");
            laptop1.PrintLaptop();
            Console.WriteLine("----------------------Laptop2----------------------");
            laptop2.PrintLaptop();


            Console.WriteLine("");
        }

    }
}