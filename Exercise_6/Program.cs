using System;
using static Exercise_6.Program;

namespace Exercise_6
{
    public class Number
    {
        public int PrvBroj { get; set; }
        public int VtorBroj { get; set; }
        public char Operacija { get; set; }

        public int Rezultat = 0;

    }
   
    class Program
    {
      
        public static void Main(string[] args)
        {
            var broevi = new Number();
            var br1 = broevi.PrvBroj;
            var br2 = broevi.VtorBroj;
            var operacija = broevi.Operacija;
            var rezultat = broevi.Rezultat;
         
           
            Console.Write("vnesete prv broj : ");
            br1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vnesete karakter : + - * / % ");
            operacija = Console.ReadLine()[0];
            Console.Write("vnesete vtor broj : ");
            br2 = Convert.ToInt32(Console.ReadLine());

           
            if(br1 > 255)
            {
                throw new FoundException(br1);
            }
      
            try
            {
                
            }
            catch (Exception e )
            {
                Console.WriteLine("Porakata na exception e" + e.Message);
                if (e is FoundException)
                {
                   
                    Console.WriteLine("found exception");
                }
            }
             
            if (operacija == '+')
            {
                rezultat = br1 + br2;
                Console.WriteLine($"Rezultatot e {rezultat} ");
            }
            else if (operacija == '-')
            {
                rezultat = br1 - br2;
                Console.WriteLine($"Rezultatot e {rezultat} ");
            }

            else if (operacija == '*')
            {
                rezultat = br1 * br2;
                Console.WriteLine($"Rezultatot e : {rezultat}");

            }

            else if (operacija == '/')
            {
                rezultat = br1 / br2;
                Console.WriteLine($"Rezultatot e : {rezultat}");
            }
            else if (operacija == '%')
            {
                rezultat = br1 % br2;
                Console.WriteLine($"Ostatokot e : {rezultat}");

            }
            else
            {
                Console.WriteLine(" Pogresen vneseno ");
            }


        }
        public class FoundException : Exception
        {
            public FoundException(int br1)
                : base("found.")
            {
            }
        }

    }
}   

