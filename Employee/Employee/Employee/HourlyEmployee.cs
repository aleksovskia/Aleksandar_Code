using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaci.Employee
{
    public class HourlyEmployee : Employee

    {
        public int Hours { get; set; }
        public double HourRate { get; set; }
        public double Osnovna { get; set; }

        public override double Bonus()
        {
            var razlika = Hours - 320;
            if (Hours > 320)
            {
                return (Hours - 320) * ((HourRate * 50 / 100) + HourRate);
            }
            else
            {
                return 0;
            }
        }

        public override double Plata()
        {
            return (Hours * HourRate) + Bonus();
        }
        public void PecatiHourly()
        {
            Console.Write(Ime + Godini + Hours + HourRate);
           

        }


    }
}


