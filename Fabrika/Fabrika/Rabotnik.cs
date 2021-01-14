using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrika
{
    public class Rabotnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Plata { get; set; }

        public Rabotnik()
        {

        }
        public Rabotnik(string ime, string prezime, int plata)
        {
            Ime = ime;
            Prezime = prezime;
            Plata = plata;

        }
        public double GetPlata()
        {

            return  Plata;
        }
        public void PecatiVraboteni()
        {
            Console.WriteLine();
            Console.WriteLine($"ime na vraboten : {Ime}");
            Console.WriteLine($"prezime na Vraboten : {Prezime}");
            Console.WriteLine($"Plata na vraboten : {Plata}");
        }
    }

}
