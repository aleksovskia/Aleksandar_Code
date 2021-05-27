using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaci.Employee

{
    public class SalaryEmployee : Employee
    {
        public SalaryEmployee(int tipRabotnici, string ime, int godini, int hours, int hoursRate)
        {
            Ime = ime;
            Godini = godini;

        }

        public double Osnovna { get; set; }
        public override double Bonus()
        {
            return Osnovna * Godini / 100;
        }

        public override double Plata()
        {
            return Osnovna + Bonus();
        }
        public void PecatiSallary()
        {
            Console.Write(TipRabotnici + Ime + Godini + Iskustvo + Osnovna);
        }
    }


}
