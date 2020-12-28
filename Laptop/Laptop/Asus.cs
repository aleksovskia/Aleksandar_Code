using Laptop.Graphics;
using Laptop.Processor;
using Laptop.Ram;
using Laptop.SSD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    public class Asus : Laptop
    {

        public Asus(IProcessor processor, IRam ram, ISSD ssd, IGraphics graphics)
            : base("Asus", processor, ram, graphics)
        {
        }
    }
}
