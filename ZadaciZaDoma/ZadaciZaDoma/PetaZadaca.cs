using System;
using System.Collections.Generic;
using ZadaciZaDoma.Ureduvanje_Dom;

namespace ZadaciZaDoma
{
    public class PetaZadaca 

    {
        public void RunPetaZadaca()
       
        {
             
            var n = Convert.ToInt32(Console.ReadLine());
            var ListaNaKukji = new List<Kukja>();
            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var podeleni = input.Split(" ");

                var masaSirina = Convert.ToInt32(podeleni[0]); 
                var masaDolzina = Convert.ToInt32(podeleni[1]);

                var sobaDolzina = Convert.ToInt32(podeleni[2]);
                var sobaSirina = Convert.ToInt32(podeleni[3]);
                 
                var adresa = podeleni[4];


                var masa = new Masa(masaSirina, masaDolzina);
                var soba = new Soba(masa, sobaSirina, sobaDolzina);
                var kukja = new Kukja(soba,adresa);

                ListaNaKukji.Add(kukja);


            }   
            foreach(var kukja in ListaNaKukji)
            {
                Console.WriteLine();
                kukja.Pecati();
                Console.WriteLine();
            }
             
        }

    }

       

    
}

