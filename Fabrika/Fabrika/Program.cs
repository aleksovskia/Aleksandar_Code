using System;
using System.Collections.Generic;

namespace Fabrika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Broj na Vraboteni : ");
            var n = Convert.ToInt32(Console.ReadLine());
            var ListaNaVraboteni = new List<Rabotnik>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"------- Vraboten {i + 1} -------");
                Console.WriteLine();
                Console.WriteLine("Ime na vraboteniot : ");
                string ime = Console.ReadLine();
                Console.WriteLine("Prezime na vraboteniot  : ");
                string prezime = Console.ReadLine();
                Console.WriteLine("Plata na vraboteniot : ");
                int plata = Convert.ToInt32(Console.ReadLine());
               
                ListaNaVraboteni.Add(new Rabotnik(ime, prezime, plata));
            }
            Console.WriteLine();
            Console.WriteLine("Vnesi ja prosecnata plata za da ti gi ispecati site vraboteni so prosecna plata ili pogolema od prosecnata plata ( 30.000 ) : "); //30.000
            int ProsecnaPlata = Convert.ToInt32(Console.ReadLine());
            
            PecatiSoPlata(ListaNaVraboteni, ProsecnaPlata);
            Console.WriteLine();
            Console.WriteLine("Site Vraboteni : ");
            foreach (var informacii in ListaNaVraboteni)
            {
                
                informacii.PecatiVraboteni();
                Console.WriteLine();
            }
        }
        public static void 
            
            PecatiSoPlata(List<Rabotnik> fabrika, int ProsecnaPlata)
        {
            Console.WriteLine();
            Console.WriteLine("Vraboteni so plata povekje od 30000 denari : ");
            foreach (var vraboreni in fabrika)
            {
                if (vraboreni.Plata >= ProsecnaPlata)
                {
                   
                    vraboreni.PecatiVraboteni();
                }
            }
        }  
    }
}
