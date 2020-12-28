using Laptop.Graphics;
using Laptop.Processor;
using Laptop.Ram;
using Laptop.SSD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    public class Dell : Laptop
    {

        public Dell(IProcessor processor, IRam ram, ISSD ssd, IGraphics graphics)
            : base("Dell", processor, ram, ssd, graphics)
        {
        }
    }
}