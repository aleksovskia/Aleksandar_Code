using Ispit_NaucenTrud_Aleksandar;
using System;
using System.Collections.Generic;
using static Ispit_NaucenTrud_Aleksandar.PhDStudent;
using static Ispit_NaucenTrud_Aleksandar.PhDStudent.InvalidOcenkaException;

namespace Ispit_NaucenTrud_Aleksandar
{
    class Program
    {
        static void Main(string[] args)
        {
            var polozeniPredmeti = new List<Subject>() {
                new Subject("Programiranje",10 ) ,
                new Subject("Kalkolus",10 ) ,
                new Subject("Fizika",10 )
            };

            var student = new Student("Marko", 1234, 2010 );

            foreach (var predmet in polozeniPredmeti)
            {
                try
                {
                    student.NovaLista(predmet);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var phdStudent = new PhDStudent("Petar", 123456, 2003);

            var phdSubjects = new List<Subject>() {
                new Subject("KProgramiranje",10) ,
                new Subject("Kalkolus",9) ,
                new Subject("Fizika",10),
                new Subject("Menadzment",8) ,
                new Subject("Dizajn na softver",10)
            };
            var articles = new List<Article>()
            {
                new Article(){Naslov="Trud 1", Tip = VidNaTrud.Conference, GodinaNaIzdavanje=2008},
                new Article(){Naslov="Trud 2",Tip = VidNaTrud.Journal, GodinaNaIzdavanje=2008},
                new Article(){Naslov="Trud 3",Tip = VidNaTrud.Journal, GodinaNaIzdavanje=2005}
            };
            foreach (var predmet in phdSubjects)
            {
                try
                {
                    phdStudent.NovaLista(predmet);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            foreach (var article in articles)
            {
                try
                {
                    phdStudent.AddArticle(article);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PHDStudent count");
            PhDStudent.Count(phdStudent.Trudovi);
            Console.WriteLine();
            var faculty = new Faculty() { ImeNaFakultet = "PMF", Studenti = new List<Student>() { student, phdStudent } };
            Console.WriteLine("Faculty print");
            faculty.Pecati();
        }
    }
    public enum VidNaTrud
    {
        Conference,
        Journal
    }
    public class Article
    {
        public string Naslov { get; set; }
        public VidNaTrud Tip { get; set; }
        public int GodinaNaIzdavanje { get; set; }
    }
    public class Subject
    {
        public string ImeNaPredmet { get; set; }
        public int Ocenka { get; set; }

        public Subject(string imeNaPredmet, int ocenka)
        {
            ImeNaPredmet = imeNaPredmet;
            Ocenka = ocenka;
        }
    }
    public class Student
    {
        public string ImeNaStudentot { get; set; }
        public int Indeks { get; set; }
        public int GodinaNaUpis { get; set; }
        public List<Subject> PolozeniPredmeti = new List<Subject>();

        public Student(string imeNaStudent, int indeks, int godinaNaUpis)
        {
            ImeNaStudentot = imeNaStudent;
            Indeks = indeks;
            GodinaNaUpis = godinaNaUpis;
        }
        public void NovaLista(Subject predmet)
        {
            if (predmet.Ocenka > 10)
            {
                throw new InvalidOcenkaException(predmet);
            }
            PolozeniPredmeti.Add(predmet);
        }
        public virtual double Rang()
        {
            var prosek = 0.0;
            foreach (var polozenPredmet in PolozeniPredmeti)
            {
                prosek += polozenPredmet.Ocenka;
            }
            return prosek / PolozeniPredmeti.Count;
        }
        public virtual void Pecati()
        {
            Console.WriteLine($"Indeks {Indeks} Ime {ImeNaStudentot} Godina {GodinaNaUpis} Rang {Rang()}");
        }
    }
    public class Faculty
    {
        public string ImeNaFakultet { get; set; }
        public List<Student> Studenti { get; set; }
        public Faculty()
        {
            Studenti = new List<Student>();
        }
        public void Pecati()
        {
            int obicenStudent = 0;
            int phdStudent = 0;
            foreach (var student in Studenti)
            {
                student.Pecati();
                if (student is PhDStudent)
                {
                    phdStudent++;
                }
                else
                {
                    obicenStudent++;
                }
                Console.WriteLine($"Broj na phd Studenti {phdStudent} broj na obicni Studenti {obicenStudent}");
            }
        }
    }
    public class PhDStudent : Student
    {
        public List<Article> Trudovi { get; set; } = new List<Article>();
        public PhDStudent(string imeNaStudentot, int indeks, int godinaNaUpis)
           : base(imeNaStudentot, indeks, godinaNaUpis)
        {

        }
        public void AddArticle(Article article)
        {
            if (GodinaNaUpis > article.GodinaNaIzdavanje)
            {
                throw new InvalidGodinaNaIzdavanjeException(article);
            }
            Trudovi.Add(article);
        }
        public override double Rang()
        {
            var rang = base.Rang();
            foreach (var trud in Trudovi)
            {
                if (trud.Tip == VidNaTrud.Conference)
                {
                    rang += 1;
                }
                if (trud.Tip == VidNaTrud.Journal)
                {
                    rang += 3;
                }
            }
            return rang;
        }
        public static void Count(List<Article> Tipovi)
        {
            var conferenceArticles = 0;
            var journalArticles = 0;
            foreach (var tip in Tipovi)
            {
                if (tip.Tip == VidNaTrud.Conference)
                {
                    conferenceArticles++;
                }
                if (tip.Tip == VidNaTrud.Journal)
                {
                    journalArticles++;
                }
            }

            Console.WriteLine($"Conference Articles: {conferenceArticles}, Journal Articles {journalArticles}");
        }
        public class InvalidOcenkaException : Exception
        {
            public InvalidOcenkaException(Subject subject)
                 : base($" Nemoze da se dodadat predmeti {subject.ImeNaPredmet} {subject.Ocenka}")
            {

            }
            public class InvalidGodinaNaIzdavanjeException : Exception
            {
                public InvalidGodinaNaIzdavanjeException(Article article)
                     : base($"Nemozat da se dodadat article {article.Naslov} {article.GodinaNaIzdavanje}")
                {

                }
            }
            
        }
    }
}

    


