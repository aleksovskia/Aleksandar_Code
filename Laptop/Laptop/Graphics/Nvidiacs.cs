using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop.Graphics
{
    public class Nvidia : IGraphics
    {

        public int Gb { get; set; }


        public void PrintGb()
        {
            Console.WriteLine("Nvidia Graphics: " + Gb);
        }
    }
}