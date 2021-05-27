using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaciZaDoma
{
    public class TretaZadaca_Agol
    {
        public void RunTretaZadaca()
        {
            Console.WriteLine("vnesi stepeni na agolot");
            var step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vnesi minuti na agolot");
            var minu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vnesi sekindi na agolot");
            var sek = Convert.ToInt32(Console.ReadLine());


            if (step >= 0 && step <= 360)
            if (minu >= 0 && minu <= 60)
            if (sek >= 0 && sek < 60)
            Console.WriteLine("Agol");
            else
            Console.WriteLine("Nevalidni vrednosti za agol");

        }

    }
    public class Agol
    {
        public int Step { get; set; }
        public int Minu { get; set; }
        public int Sek { get; set; }

        public Agol()

        {
            Step = 180;
            Minu = 0;
            Sek = 60;
        }
        public Agol(int step, int minu, int sek)
        {
            Step = step;
            Minu = minu;
            Sek = sek;
        }
    }
}
