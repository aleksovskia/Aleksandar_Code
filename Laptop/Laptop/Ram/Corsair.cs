
using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop.Ram
{
    public class Corsair : IRam
    {
        public int Mhz { get; set; }
        public Corsair(int mhz)
        {
            Mhz = mhz;
        }
        public void PrintMhz()
        {
            Console.WriteLine("Corsair ram:" + Mhz);
        }
    }
}