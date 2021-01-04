using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma.Ureduvanje_Dom
{

    public class Masa
    {
        public int Dolzina { get; set; }
        public int Sirina { get; set; }


        public Masa()
        {

        }
        public Masa(int dolzina, int sirina)

        {
            Dolzina = dolzina;
            Sirina = sirina;

        }
        public void Pecati()
        {
            Console.WriteLine($"- Masa : {Dolzina} {Sirina}  ");

        }


    }
}