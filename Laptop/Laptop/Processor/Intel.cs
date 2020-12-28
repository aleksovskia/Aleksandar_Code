using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop.Processor
{
    public class Intel : IProcessor
    {
        public float Ghz { get; set; }
        public void PrintMhz()
        {
            Console.WriteLine("Intel processor: " + Ghz);
        }
    }
}