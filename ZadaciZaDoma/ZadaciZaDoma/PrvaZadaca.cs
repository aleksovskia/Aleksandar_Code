using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma
{
    public class PrvaZadaca
    {
        public void RunPrvaZadaca()
        {
            var tocka1 = new Tocka()
            {
                X = 1,
                Y = 3
            };

            var tocka2 = new Tocka()
            {
                X = 3,
                Y = 1
            };

            var tocka3 = new Tocka()
            {
                X = 5,
                Y = 8
            };

            Console.WriteLine(Tocka.Distance2D(tocka1, tocka2));
            //Console.WriteLine(Tocka.Distance3D(tocka1, tocka2));
            Console.WriteLine(Tocka.AreOnSameLine(tocka1, tocka2, tocka3));
        }
    }

    public class Tocka
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Tocka()
        {

        }

        public Tocka(int x, int y)
        {
            X = x;
            Y = y;
            Z = 0;
        }

        public Tocka(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static double Distance2D(Tocka t1, Tocka t2)
        {
            var distance = Math.Sqrt((t1.X - t2.X) * (t1.X - t2.X) + (t1.Y - t2.Y) * (t1.Y - t2.Y));
            var rounded = Math.Round(distance, 2);
            return rounded;
        }

        public static double Distance3D(Tocka t1, Tocka t2)
        {
            var distance = Math.Sqrt((t1.X - t2.X) * (t1.X - t2.X) + (t1.Y - t2.Y) * (t1.Y - t2.Y) + (t1.Z - t2.Z) * (t1.Z - t2.Z));
            return distance;
        }

        public static bool AreOnSameLine(Tocka t1, Tocka t2, Tocka t3)
        {
            return (t2.Y - t1.Y) / (t2.X - t1.X) == (t3.Y - t2.Y) / (t3.X - t2.X);
        }
    }
}
