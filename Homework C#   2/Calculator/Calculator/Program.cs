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



            if (PrvBorj >= 100)
            {
                throw new EmployeeNotFoundException();
               
            }
            Console.WriteLine("nevaliden vnes");
            try
            {
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Fativ exception");
                Console.WriteLine("Porakata na exception e" + e.Message);
                if (e is EmployeeNotFoundException)
                {
                    //nekoja logika dokolku fativ konkreten tip na exception
                    Console.WriteLine("Fativ employee not found exception");
                }

            }
            Console.WriteLine("Zavrisiv so izvrsuvanje na programata");



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

        public class EmployeeNotFoundException : Exception
        {
            public EmployeeNotFoundException()
                : base("Employee not found.")
            {
            }
        }
    }
}
