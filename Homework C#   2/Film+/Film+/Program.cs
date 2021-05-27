using System;
using System.Collections.Generic;

namespace Film_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Broj na filmovi : ");
            var n = Convert.ToInt32(Console.ReadLine());
            var ListaFilmovi = new List<Movie>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"------- Movie {i + 1} -------");
                Console.WriteLine();
                Console.WriteLine("Ime na Filmot : ");
                string ime = Console.ReadLine();
                Console.WriteLine("Reziser na Filmot : ");
                string reziser = Console.ReadLine();
                Console.WriteLine("Zarn na Filmot : ");
                string zanr = Console.ReadLine();
                Console.WriteLine("Godina na Filmot : ");
                int godina = int.Parse(Console.ReadLine());
                ListaFilmovi.Add(new Movie(ime, reziser, zanr, godina));
            }

          //  foreach (var informacii in ListaFilmovi)
          // {
          //     informacii.Pecati();
          //     Console.WriteLine();
          // }

            Console.WriteLine("Vnesete godina za da se ispecatat samo filmovite od taa godina : ");
            int GodinaNaFilm = Convert.ToInt32(Console.ReadLine());
            PecatiPoGodina(ListaFilmovi, GodinaNaFilm);
        }
        public static void PecatiPoGodina(List<Movie> movies, int godina)
        {
            foreach (var movie in movies)
            {
                if (movie.Godina == godina)
                {
                    movie.Pecati();
                }
            }
        }
    }
}
