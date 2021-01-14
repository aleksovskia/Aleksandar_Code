using System;
using System.Collections.Generic;

namespace Dogovor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var podpisuvaci = input.Split(" ");

      

               var ime = podpisuvaci[0];
               var prezime = podpisuvaci[1];
               var embg = Convert.ToInt32(podpisuvaci[2]);
                

            


            }
        
            
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
        public void Podpisuvaci()
        {
            for (int i = EMBG; i == EMBG; i++)
            {
                if (EMBG == EMBG)
                {
                    Console.WriteLine($"Postojat Potpisuvaci so ist embg {EMBG}");
                }
                else
                {

                }
            }
           

                 
        }

    }
    public class Dogovor
    {

        int brojNaDogovot { get; set; }
        public Dogovor()
        {
              

        }




        public void Podpisuvaci()
        {
            Console.WriteLine($"Dogovor 1 : ");
              

        }
    }     
    
}
