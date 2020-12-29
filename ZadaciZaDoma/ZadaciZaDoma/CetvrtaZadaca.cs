using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma
{
    class CetvrtaZadaca
    {
        public void RunCetvrtaZadaca()
        {
            var radius = new Krug()
            {
                R = 5
               
            };
            var Pi = new Krug()
            {
                P = 3.14
            };


            Console.WriteLine(Krug.Plostina(radius, Pi));
            Console.WriteLine(Krug.Perimetar(radius, Pi));
            Console.WriteLine(Krug.DaliSeEdnakvi(radius, Pi));



        }
        public class Krug
        {
            public float R { get; set; }
            public double P  { get; set;}

            public Krug()
            {

            }

            public Krug(float r, double p)
            {
                R = r;
                P = p;
            }
            public static double Plostina(Krug r,Krug p)
                
            {
                var plostina = Math.Sqrt(p.P * r.R * r.R);
                var rounded = Math.Round(plostina, 2);
                return rounded;
            }
            public static double Perimetar(Krug r,Krug p)
            {
                var perimetar = Math.Sqrt(2 * r.R * p.P);
                var rounded = Math.Round(perimetar, 2);
                return rounded;
            }
            public static bool DaliSeEdnakvi(Krug r,Krug p)
            {
                return (p.P * r.R * r.R) == (2 * r.R * p.P);
            }





        }
      
        
    




       


       
    }
}
