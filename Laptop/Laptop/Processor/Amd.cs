using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop.Processor
{
    public class AMD : IProcessor
    {
        public float Ghz { get; set; }
        public void PrintMhz()
        {
            Console.WriteLine("Intel processor: " + Ghz);
        }
    }
}