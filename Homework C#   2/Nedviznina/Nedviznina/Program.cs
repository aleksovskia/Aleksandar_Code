using System;
using System.Collections.Generic;

namespace Nedviznina
{
    class Program
    {
        static void Main(string[] args)
        {
            var nedviznini1 = new Vila();
            {
                nedviznini1.Nedviznini = new Nedviznina("Kukja vo centar", 60, 850);
                nedviznini1.Luksuz = 0;
                nedviznini1.Pecati();
                nedviznini1.DanokNaImot();
              //nedviznini1.DanokNaImotLuksuz();
            }
            Console.WriteLine();
            var nedviznini2 = new Vila();
            {
                nedviznini2.Nedviznini = new Nedviznina("Vila na Vodno", 110, 1120);
                nedviznini2.Luksuz = 10;
                nedviznini2.Pecati();
                nedviznini2.DanokNaImot();
              //nedviznini2.DanokNaImotLuksuz();
            }
        }
        public class Nedviznina
        {
            public dynamic Adresa { get; set; }
            public int Kvadratura { get; set; }
            public int CenaNaKvadrat { get; set; }
            public Nedviznina()
            {

            }
            public Nedviznina(dynamic adresa, int kvadratura, int cenaNaKvadrat)
            {
                Adresa = adresa;
                Kvadratura = kvadratura;
                CenaNaKvadrat = cenaNaKvadrat;
            }
            public double Cena()
            {
                return Kvadratura * CenaNaKvadrat;
            }
            public void Pecati()
            {
                Console.WriteLine($"{Adresa}, Kvadratura : {Kvadratura} m2, Cena po kvadrat : {CenaNaKvadrat} euro");
            }
            public double  DanokNaImot()
            {
                return ((Kvadratura * CenaNaKvadrat) / 100) * 5;  
            }
        }
        public class Vila
        {
            public Nedviznina Nedviznini;
            public int Luksuz { get; set; } 
            public Vila()
            {
                Nedviznini = new Nedviznina();
                Luksuz = 0;
            }
            public Vila(Nedviznina nedviznini, int luksuz)
            {
                Nedviznini = nedviznini;
                Luksuz = luksuz;
            }
            public void Pecati()
            {
                Nedviznini.Pecati();
            }
            public void DanokNaImot()
            {
                Console.WriteLine($"Danok na Luksuz : {Luksuz} %");
                Console.WriteLine($"Danok za {Nedviznini.Adresa} e : {(Nedviznini.DanokNaImot() + ((Nedviznini.Kvadratura * Nedviznini.CenaNaKvadrat) / 100) * Luksuz)} euro");     
                // Console.WriteLine($"Danok za {Nedviznini.Adresa} e : {Nedviznini.DanokNaImot()}");
                // Nedviznini.DanokNaImot();
            }
           // public void DanokNaImotLuksuz()
           // {
           //     Console.WriteLine($"Danok na Luksuz : {Luksuz}");
           //     Console.WriteLine($"Danok za {Nedviznini.Adresa} e : {(Nedviznini.DanokNaImot() + ((Nedviznini.Kvadratura * Nedviznini.CenaNaKvadrat) / 100) * Luksuz)}");
           // }
        }
    }   
}