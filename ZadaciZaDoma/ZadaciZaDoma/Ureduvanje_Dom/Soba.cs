using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma.Ureduvanje_Dom
{
    public class Soba

    {
        Masa Masa { get; set; }
        public int Dolzina { get; set; }
        public int Sirina { get; set; }

        public Soba()
        {

        }
        public Soba(Masa masa, int dolzina, int sirina)
        {
            Masa = masa;
            Dolzina = dolzina;
            Sirina = sirina;
        }
        public void Pecati()
        {
            Console.Write($"- Soba : {Dolzina} / {Sirina} ");
            Masa.Pecati();
        }
    }
}
