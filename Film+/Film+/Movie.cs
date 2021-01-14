using System;
using System.Collections.Generic;
using System.Text;

namespace Film_
{
   public class Movie
    { 
        private string Ime { get; set; }
        private string Reziser { get; set; }
        private string Zarn { get; set; }
        public int Godina { get; set; }

        public Movie()
        {

        }
        public Movie(string ime, string reziser, string zarn, int godina)
        {
            Ime = ime;
            Reziser = reziser;
            Zarn = zarn;
            Godina = godina;
        }
        public void Pecati()
        {
            Console.WriteLine();
            Console.WriteLine($" - Ime     : {Ime} ");
            Console.WriteLine($" - Reziser : {Reziser} ");
            Console.WriteLine($" - Zarn    : {Zarn} ");
            Console.WriteLine($" - Godina  : {Godina} ");
            Console.WriteLine();
        }
 
    }
}
