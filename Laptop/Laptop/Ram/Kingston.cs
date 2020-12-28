using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop.Ram
{
    public class Kingston : IRam
    {
        public int Mhz { get; set; }
        public Kingston(int mhz)
        {
            Mhz = mhz;
        }
        public void PrintMhz()
        {
            Console.WriteLine("Kingston ram:" + Mhz);
        }
    }
}