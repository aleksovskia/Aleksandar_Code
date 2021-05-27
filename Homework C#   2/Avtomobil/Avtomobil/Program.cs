using System;
using System.Collections.Generic;

namespace Avtomobil
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
           
            car.Sopstvenik = new Person("Riste", "Ristevski");
            car.DataNaKupuvanje = new Date(2019, 12, 12);
            car.Cena = 230000f;
            // Console.WriteLine("------------------- car ----------------");
            //car.Print();

            var sopstvenik = new Person("Aleksandar", "Tanevski");
            var dataNaKupuvanje = new Date(2018, 01, 01);
            var cena = 100000f;
            var car1 = new Car(sopstvenik, dataNaKupuvanje, cena);

            var car2 = new Car()
            {
                Sopstvenik = new Person("Aleksandar", "Aleksovski"),
                DataNaKupuvanje = new Date(2021, 01, 16),
                Cena = 500000f
            };

            //Console.WriteLine("------------------- car 1 ----------------");
            //car1.Print();
            //Console.WriteLine("------------------- car 2 ----------------");
            //car2.Print();

            var listaOdAvtomobili = new List<Car>() { car, car1, car2 };
            PoevtiniOd(listaOdAvtomobili,500000f);
        }
        public static void PoevtiniOd(List<Car> cars, float cena)
        {
           for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Cena < cena)
                {
                  Console.WriteLine($"----- Car - {i + 1} -----");
                  Console.WriteLine();
                  cars[i].Print();
                  Console.WriteLine();
                }

            }
      
           // foreach (var car in cars)
           // {
           //     if(car.Cena < cena)
           //     {
           //        car.Print();
           //    }
           // }
        }
        public class Car
        {
            public float Cena { get; set; }
            public Person Sopstvenik;
            public Date DataNaKupuvanje;

            public Car()
            {
                Sopstvenik = new Person();
                DataNaKupuvanje = new Date();
                Cena = 0.0f; 
            }

            public Car(Person sopstvenik, Date dataNaKupuvanje, float cena)
            {
                Sopstvenik = sopstvenik;
                DataNaKupuvanje = dataNaKupuvanje;
                Cena = cena;
            }

            public float GetCena()
            {
                return Cena;
            }

            public void Print()
            {
                Sopstvenik.Print();
                DataNaKupuvanje.Print();
                Console.WriteLine("Cena : " + Cena);
            }
        }

        public class Date
        {
            public int Godina { get; set; }
            public int Mesec { get; set; }
            public int Den { get; set; }

            public Date()
            {
                Godina = 0;
                Mesec = 0;
                Den = 0;
            }

            public Date(int godina, int mesec, int den)
            {
                Godina = godina;
                Mesec = mesec;
                Den = den;
            }

            public void Print()
            {
                Console.WriteLine($"Datum na kupuvanje : {Godina}.{Mesec}.{Den}");
            }
        }

        public class Person
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }

            public Person()
            {
                Ime = "not specifed";
                Prezime = "not specifed";
            }

            public Person(string ime, string prezime)
            {
                Ime = ime;
                Prezime = prezime;
            }

            public void Print()
            {
                Console.WriteLine($"Ime : {Ime}" );
                Console.WriteLine($"Prezime : {Prezime}");
            }
        }
    }
}