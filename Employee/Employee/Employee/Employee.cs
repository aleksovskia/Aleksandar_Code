using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaci.Employee
{
    public abstract class Employee
    {
        public string Ime { get; set; }
        public int Godini { get; set; }
        public int Iskustvo { get; set; }
        public int TipRabotnici { get; set; }


        public abstract double Plata();


        public abstract double Bonus();


        public static bool Sporedi(Employee e1, Employee e2)
        {
            return e1.Godini == e2.Godini && e1.Bonus() == e2.Bonus();

        }

        
    }

}
