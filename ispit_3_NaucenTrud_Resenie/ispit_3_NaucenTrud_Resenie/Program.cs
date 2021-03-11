using System;
using System.Collections.Generic;

namespace Ispit0202
{
    class Program
    {
        static void Main(string[] args)
        {
            var subjects = new List<Subject>() {
                new Subject("Kalkulus",10 ) ,
                new Subject("Matematika",10 ) ,
                new Subject("Fizika",10 )
            };

            var student = new Student("Marko", 1234, 2010);

            foreach (var subject in subjects)
            {
                try
                {
                    student.AddSubject(subject);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            var phdStudent = new PHDStudent("Petar", 123456, 2003);

            var phdSubjects = new List<Subject>() {
                new Subject("Kalkulus",10) ,
                new Subject("Matematika",9) ,
                new Subject("Fizika",10),
                new Subject("Kalkulus",8) ,
                new Subject("Matematika",10)
            };

            var articles = new List<Article>()
            {
                new Article(){Title="Article 1", Type = ArticleType.Conference, PublishYear=2008},
                new Article(){Title="Article 2",Type = ArticleType.Journal, PublishYear=2008},
                new Article(){Title="Article 3",Type = ArticleType.Journal, PublishYear=2005}
            };

            foreach (var subject in phdSubjects)
            {
                try
                {
                    phdStudent.AddSubject(subject);
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
            PHDStudent.Count(phdStudent.Articles);
            Console.WriteLine();
            var faculty = new Faculty() { Name = "PMF", Students = new List<Student>() { student, phdStudent } };
            Console.WriteLine("Faculty print");
            faculty.Print();
        }
    }

    public enum ArticleType
    {
        Conference,
        Journal
    }

    public class Article
    {
        public string Title { get; set; }
        public ArticleType Type { get; set; }
        public int PublishYear { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Subject(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }

    public class Student
    {
        protected string Name;
        protected int Index;
        protected int StartYear;
        protected List<Subject> Subjects = new List<Subject>();

        public Student(string name, int index, int startYear)
        {
            Name = name;
            Index = index;
            StartYear = startYear;
        }

        public void AddSubject(Subject s)
        {
            if (s.Grade > 10)
            {
                throw new InvalidGradeException(s);
            }
            Subjects.Add(s);
        }

        public virtual double Rang()
        {
            var rang = 0.0;

            foreach (var subject in Subjects)
            {
                rang += subject.Grade;
            }

            return rang / Subjects.Count;
        }

        public void Print()
        {
            Console.WriteLine($"{Index} {Name} {StartYear} {Rang()}");
        }
    }

    public class PHDStudent : Student
    {
        public List<Article> Articles { get; private set; } = new List<Article>();

        public PHDStudent(string name, int index, int startYear)
            : base(name, index, startYear)
        {

        }

        public void AddArticle(Article a)
        {
            if (StartYear > a.PublishYear)
            {
                throw new InvalidPublishDateException(a);
            }
            Articles.Add(a);
        }

        public override double Rang()
        {
            var rang = base.Rang();
            foreach (var article in Articles)
            {
                if (article.Type == ArticleType.Conference)
                {
                    rang += 1;
                }
                if (article.Type == ArticleType.Journal)
                {
                    rang += 3;
                }
            }
            return rang;
        }

        public static void Count(List<Article> articles)
        {
            var conferenceArticles = 0;
            var journalArticles = 0;
            foreach (var article in articles)
            {
                if (article.Type == ArticleType.Conference)
                {
                    conferenceArticles++;
                }
                if (article.Type == ArticleType.Journal)
                {
                    journalArticles++;
                }
            }

            Console.WriteLine($"Conference Articles: {conferenceArticles}, Journal Articles {journalArticles}");
        }
    }

    public class Faculty
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public void Print()
        {
            var phdStudents = 0;
            var students = 0;
            foreach (var student in Students)
            {
                student.Print();
                if (student is PHDStudent) phdStudents++;
                else students++;
            }
            Console.WriteLine($"PHD Student count = {phdStudents} Regular students = {students}");
        }
    }

    public class InvalidGradeException : Exception
    {
        public InvalidGradeException(Subject subject)
        : base($"Cannot add subject {subject.Name} {subject.Grade}")
        {

        }
    }
    public class InvalidPublishDateException : Exception
    {
        public InvalidPublishDateException(Article article)
        : base($"Cannot add article {article.Title} {article.PublishYear}")
        {

        }
    }
}

