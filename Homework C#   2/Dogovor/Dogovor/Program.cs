using System;
using System.Collections.Generic;

namespace Dogovor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var podpisuvaci = new List<Dogovor>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var podpisuvac = input.Split(" ");

                var ime = podpisuvaci[0];
                var prezime = podpisuvaci[1];
                var embg = Convert.ToInt32(podpisuvaci[2]);

            }
       
            Console.WriteLine();
            
        }
       

    }
    public class Potpisuvac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int EMBG { get; set; }

        public Potpisuvac()
        {

        }
        public Potpisuvac(string ime, string prezime, int embg)
        {
            Ime = ime;
            Prezime = prezime;
            EMBG = embg;
        }
        public void PodpisuvacPrint()
        {

         
        }

    }
    public class Dogovor
    {

        int brojNaDogovot { get; set; }
        string Osiguruvanje { get; set; }

        public Dogovor()
        {
            
        }
        public void PodpisuvacDogovor()
        {
            Console.WriteLine($"Osiguruvane 1 : ");
        }
    }     
    
}
