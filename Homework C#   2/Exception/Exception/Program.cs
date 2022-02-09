using System;
using System.Collections.Generic;
using System.Linq;
namespace Zadaci
{
    class Planeta
    {
        public string Ime { get; set; }
        public int Masa { get; set; }
        public int Oddalecenost { get; set; }
        public int ProbajException()
        {
            var broj = 1;
            // nekoja logika tuka
            if (broj == 1) // ako uslovot ne e ispolnet, frli exception
            {
                throw new EmployeeNotFoundException();
            }
            if (broj == 2)
            {
                throw new EmployeeAgeIsInvalid();
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var planeta = new Planeta();
            try
            {
                planeta.ProbajException();
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
                if (e is EmployeeAgeIsInvalid)
                {
                    //nekoja logika dokolku fativ konkreten tip na exception vo ovoj slucaj employeeage exception
                    Console.WriteLine("Fativ employee age invalid exception");
                }
            }
            Console.WriteLine("Zavrisiv so izvrsuvanje na programata");
        }
    }
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException()
            : base("Employee not found.")
        {
        }
    }
    public class EmployeeAgeIsInvalid : Exception
    {
        public EmployeeAgeIsInvalid()
            : base("Employee age not valid.")
        {
        }
    }
}

