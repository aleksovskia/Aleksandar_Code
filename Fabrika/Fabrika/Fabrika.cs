using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrika
{
    public class Fabrika
    {
        public string Rabotnik { get; set; }
        public int BrojNaVraboteni { get; set; }

        public void PecatiVraboteni()
        {
            Console.WriteLine($"broj na vraboteni {Rabotnik} ");
        }
        

        public Fabrika(string rabotnik, int brojNaVravoteni)
        {
            Rabotnik = rabotnik;
            BrojNaVraboteni = brojNaVravoteni;
        }

       




        
        
    }
}
