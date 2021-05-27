using System;
using System.Collections.Generic;

namespace Zadaci.Employee
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = Convert.ToInt32(Console.ReadLine());
            var filtreiranaPlata = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var rabotnici = input.Split(" ");

                var TipRabotnici = Convert.ToInt32(rabotnici[0]);
                var Ime = rabotnici[1];


                var Godini = Convert.ToInt32(rabotnici[2]);

                var Iskustvo = Convert.ToInt32(rabotnici[3]);
                var Osnovna = Convert.ToInt32(rabotnici[4]);

                var Hours = Convert.ToInt32(rabotnici[5]);
                var HoursRate = Convert.ToInt32(rabotnici[6]);


                var SalaryEmpoloyee = new SalaryEmployee (TipRabotnici, Ime , Godini, Hours, HoursRate);





            }
            foreach (var employee in filtreiranaPlata)
            {
                Console.WriteLine();
                employee.Plata();
                Console.WriteLine();

            }





        }
    }
}
