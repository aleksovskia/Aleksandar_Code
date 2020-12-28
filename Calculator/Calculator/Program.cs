using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)

        {

            int PrvBorj;
            char operacija;
            int VtorBroj;
            int Rezultat = 0;



            Console.Write("vnesete prv broj : ");
            PrvBorj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vnesete karakter : + - * / % ");
            operacija = Console.ReadLine()[0];
            Console.Write("vnesete vtor broj : ");
            VtorBroj = Convert.ToInt32(Console.ReadLine());


            if (operacija == '+')
            {
                Rezultat = PrvBorj + VtorBroj;
                Console.WriteLine($"Rezultatot e {Rezultat} ");
            }
            else if (operacija == '-')
            {
                Rezultat = PrvBorj - VtorBroj;
                Console.WriteLine($"Rezultatot e {Rezultat} ");
            }

            else if (operacija == '*')
            {
                Rezultat = PrvBorj * VtorBroj;
                Console.WriteLine($"Rezultatot e : {Rezultat}");

            }

            else if (operacija == '/')
            {
                Rezultat = PrvBorj / VtorBroj;
                Console.WriteLine($"Rezultatot e : {Rezultat}");
            }
            else if (operacija == '%')
            {
                Rezultat = PrvBorj % VtorBroj;
                Console.WriteLine($"Ostatokot e : {Rezultat}");

            }
            else
            {
                Console.WriteLine(" Pogresen vneseno ");
            }

        }

    }
}
