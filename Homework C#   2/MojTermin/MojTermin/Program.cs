using System;
using System.Collections.Generic;

namespace MojTermin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" === Testiranje na klasata Lekar===");
            Console.WriteLine("Vnesi broj na Lekari ; ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var kotizacija = new List<decimal>();
                MaticenLekar lekar;
                Console.WriteLine($"Vnes na {i+1} lekar");
                Console.WriteLine("Vnesi Faksimil");
                int faksimil = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi Ime : ");
                string ime = Console.ReadLine();
                Console.WriteLine("Vnesi Prezime");
                string prezime = Console.ReadLine();
                Console.WriteLine("vnesi pocetna plata");
                decimal pplata = decimal.Parse(Console.ReadLine());
                Console.WriteLine("vnes na broj na pacienti");
                int brPacienti = int.Parse(Console.ReadLine());
                for (int j = 0; j < brPacienti; j++)
                {
                    Console.WriteLine($"vnes {j+1} kotizacija");
                    kotizacija.Add(decimal.Parse(Console.ReadLine()));
                }
                lekar = new MaticenLekar(ime, prezime, faksimil, pplata, brPacienti, kotizacija);
                lekar.Pecati();
            }
        }
    }
    public class Lekar
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int  Faksimil { get; set; }
        public decimal PocetnaPlata { get; set; }
        public Lekar()
        {

        }
        public Lekar(string ime,string prezime,int faksimil,decimal plata)
        {
            Ime = ime;
            Prezime = prezime;
            Faksimil = faksimil;
            PocetnaPlata = plata;
        }
        public virtual void Pecati()
        {
            Console.WriteLine($"{Faksimil} : {Ime} {Prezime}");
        }
        public virtual decimal Plata()
        {
            return PocetnaPlata;
        }
    }
    class MaticenLekar : Lekar
    {
        public int Pacienti { get; set; }
        public List<decimal> Kotizacija { get; set; }
        public MaticenLekar(string ime, string prezime, int faksimil, decimal pplata, int pacienti, List<decimal> kotizacija)
        : base(ime,prezime,faksimil,pplata)
        {
            Pacienti = pacienti;
            Kotizacija = kotizacija;
        }
        public override void Pecati()
        {
            base.Pecati();
            Console.WriteLine($"Osnovna Plata na gorenavedeniot lekar e : {base.Plata():c}");
            Console.WriteLine($"Vkupnatan plata so Kotizacii e : {Plata():c}");
        }
        public override decimal Plata()
        {
            decimal kotizacii = 0;
            foreach(var kotizacija in Kotizacija)
            {
                kotizacii = kotizacija;
            }
            return base.Plata() + (kotizacii/Kotizacija.Count)*(30M/100M);
        }
    }
}
