using System;
using System.Collections.Generic;

namespace Ispit_02_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Article
    {
        public string Naslov { get; set; }
        public string Conference { get; set; }
        public string Journal { get; set; }
        public int GodinaNaIzdavanje { get; set; }
        public Article()
        {

        }
        public Article(string naslov, string conference, string journal, int godinaNaIzdavanje)
        {
            Naslov = naslov;
            Conference = conference;
            Journal = journal;
            GodinaNaIzdavanje = godinaNaIzdavanje;

        }

    }
    public class Subjekt : Article
    {
        public string ImeNaPredmet { get; set; }
        public int Ocenka { get; set; }
        public Subjekt()
        {

        }
        public Subjekt(string imeNaPredmet, int ocenka)
        {
            ImeNaPredmet = imeNaPredmet;
            Ocenka = ocenka;


        }

    }
    public class Student : Subjekt
    {
        public string ImeNaStudent { get; set; }
        public int Indeks { get; set; }
        public int GodinaNaUpis { get; set; }
        public List<Subjekt> OcenkaPolozenPredmet { get; set; }
        public Student()
        {

        }
        public Student(string imeNaStudent, int indeks, int godinaNaUpis,List<Subjekt> ocenkaPolozenPredmet, string imeNaPredmet, int ocenka)
            : base(imeNaPredmet, ocenka)
        {
            ImeNaStudent = imeNaStudent;
            Indeks = indeks;
            GodinaNaUpis = godinaNaUpis;
            OcenkaPolozenPredmet = ocenkaPolozenPredmet;
            ImeNaPredmet = imeNaPredmet;
            Ocenka = ocenka;

        }
        public void Ocenka10()
        {
            var ocenka = 0;
            for (int i = 0; i < Ocenka; i++)
               
            {
                if 

            }
        }
       

			
        public virtual double Rang()
        {
            var prosek = 0.0;
            foreach (var predmet in OcenkaPolozenPredmet)
            {
                prosek += predmet.Ocenka;

            }
            return prosek/OcenkaPolozenPredmet.Count;
        }
        public void Print()
        {
            Console.WriteLine($"Indeks : {Indeks} Godina na upis : {GodinaNaUpis} Rang : {Rang()}");
        }
        public class Faculty
        {
            public string ImeNaFakultet { get; set; }
            public List<Student> Studenti { get; set; }

            public void Print()
            {
                Console.WriteLine($"lista na Studenti : { Studenti}/n");
            }
           

        }

        public class PhDStudent : Student
        {
            public List<Article> ObjaveniTrudovi { get; set; }
            public PhDStudent()
            {

            }
            public PhDStudent(List<Article> objaveniTrudovi, string imeNaStudent, int indeks, int godinaNaUpis, List<Subjekt> ocenkaPolozenPredmet, string imeNaPredmet, int ocenka)
                :base(imeNaStudent,indeks,godinaNaUpis, ocenkaPolozenPredmet,imeNaPredmet, ocenka)
            {
                
            }
            public override double Rang()
            {
                return base.Rang();

            }
            
        }
        
    }
}

