using System;
using System.Collections.Generic;

namespace Igroteka
{
    class Program
    {
        static void Main(string[] args)
        {
            var kuopce = new list<Igracka>();
        }
    }
    public class Topka
    {
        public const double Pi = 3.14f;
        
        public string Boja { get; set; }
        public int Gustina { get; set; }
        public double Radius { get; set; }
        public Topka(string boja,int gustina,double radius)
        {
            Boja = boja;
            Gustina = gustina;
            Radius = radius;
        }
        public Topka()
        {

        }
        public double getVolumen()
        {
            var VolumenTopka = (Radius * Radius * Radius * Pi) / (3 / 4);
            var rounded = Math.Round(VolumenTopka, 2);
            return rounded;
        }
        public double getMasa()
        {
            var masaTopka = getVolumen() * Gustina;
            return masaTopka;
        }
    }
    public class Kocka : Forma 
    {
        public string Boja { get; set; }
        public int Gustina { get; set; }
        public int Visina { get; set; }
        public int Sirina { get; set; }
        public int Dlabocina { get; set; }
        public Kocka(string boja,int gustina,int visina,int sirina ,int dlabocina)
        {
            Boja = boja;
            Gustina = gustina;
            Visina = visina;
            Sirina = sirina;
            Dlabocina = dlabocina;
        }
        public Kocka()
        {

        }
        public double getVolumen()
        {
            var VolumenKocka = 0;
            VolumenKocka += Visina * Sirina * Dlabocina;
            return VolumenKocka;
        }
        public double getMasa()
        {
      
           var MasaKocka = getVolumen()* Gustina;
            return MasaKocka;
        }
    }
    public class Forma
    {

    }
    public class Igracka
    {

    }
}
