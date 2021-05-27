using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma
{
    class CetvrtaZadaca_Krug
    {
        public void RunCetvrtaZadaca()
        {
            var kruznica1 = new Krug(5);


            Console.WriteLine(kruznica1.Plostina());
            Console.WriteLine(kruznica1.Perimetar());
            Console.WriteLine(Krug.DaliSeEdnakvi(kruznica1));
        }

        public class Krug
        {
            public const float Pi = 3.14f;
            public float Radius { get; set; } //5

            public Krug()
            {

            }

            public Krug(float r)
            {
                Radius = r;
            }

            public double Plostina()

            {
                var plostina = Radius * Radius * Pi;
                var rounded = Math.Round(plostina, 2);
                return rounded;
            }

            public double Perimetar()
            {
                var perimetar = 2 * Radius * Pi;
                var rounded = Math.Round(perimetar, 2);
                return rounded;
            }

            public static bool DaliSeEdnakvi(Krug kruznica)
            {
                return kruznica.Plostina() == kruznica.Perimetar();
            }

            public bool DaliSeEdnakviNeStatic()
            {
                return Plostina() == Perimetar();
            }
        }
    }
}

