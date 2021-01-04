using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma.Ureduvanje_Dom
{
    public class Kukja
    {
        public Soba Soba { get; set; }
        public string Adresa { get; set; }

        public Kukja()
        {

        }
        public Kukja( Soba soba, string adresa)
        {
            Soba = soba;
            Adresa = adresa;


        }
        public void Pecati()
        {
            Console.Write($"- Adresa : { Adresa} ");
            Soba.Pecati();
        }
            



    }
}
