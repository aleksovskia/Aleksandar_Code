using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop.SSD
{
    public class WD : ISSD
    {
        public int Capacity { get; set; }

        public void PrintCapacity()
        {
            Console.WriteLine("WD:" + Capacity);
        }
    }
}