using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaci.Employee
{
    public class Freelancer : Employee
    {
        public double BrojNaProekti { get; set; }
        public double NizaOdSumi { get; set; }
        public override double Bonus()
        {
            return (BrojNaProekti - 5) * 1000;
        }

        public override double Plata()
        {
            return NizaOdSumi + Bonus();
        }


    }

}
      
