using Laptop.Graphics;
using Laptop.Processor;
using Laptop.Ram;
using Laptop.SSD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    public class Laptop
    {
        public string Name { get; set; }
        public IProcessor Processor { get; set; }
        public IRam Ram { get; set; }
        public ISSD SSD { get; set; }
        public IGraphics Graphics { get; set; }

        public Laptop(string name, IProcessor processor, IRam ram, ISSD ssd, IGraphics graphics)
        {
            Name = name;
            Processor = processor;
            Ram = ram;
            SSD = ssd;
            Graphics = graphics;
        }

        public Laptop(string v, IProcessor processor, IRam ram, IGraphics graphics)
        {
            Processor = processor;
            Ram = ram;
            Graphics = graphics;
        }

        public void PrintLaptop()
        {
            Console.WriteLine($"{Name}");
            Processor.PrintMhz();
            Ram.PrintMhz();
            SSD.PrintCapacity();
            Graphics.PrintGb();
        }
    }
}