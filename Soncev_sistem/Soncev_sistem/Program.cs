using System;
using System.Collections.Generic;
using System.Linq;

namespace Soncev_sistem
{
    class Program
    {
        static void Main(string[] args)
        {
            var merkur = new Planeta()
            {
                Ime = "Merkur",
                Dijametar = 4879,
                Oddalecenost = 57909227,
                Masa = 0.0553f
            };
            var venera = new Planeta()
            {
                Ime = "Veneta",
                Dijametar = 12104,
                Oddalecenost = 108209475,
                Masa = 0.815f
            };
            var zemja = new Planeta()
            {
                Ime = "Zemja",
                Dijametar = 12742,
                Oddalecenost = 149598262,
                Masa = 1f
            };
            var mars = new Planeta()
            {
                Ime = "Mars",
                Dijametar = 6779,
                Oddalecenost = 227943824,
                Masa = 0.11f
            };
            var jupiter = new Planeta()
            {
                Ime = "Jupiter",
                Dijametar = 139822,
                Oddalecenost = 778340821,
                Masa = 317.8f
            };
            var saturn = new Planeta()
            {
                Ime = "Saturn",
                Dijametar = 116464,
                Oddalecenost = 1426666422,
                Masa = 95.2f
            };

            var listaOdPlaneti = new List<Planeta>() { merkur, venera, zemja, mars, jupiter, saturn };
            var SortiranaListaOdPlaneti = listaOdPlaneti.OrderBy(x => x.Oddalecenost).ToList();

            var soncev_sistem = new SoncevSistem()
            {
                Planeti = listaOdPlaneti,
               NajbliskaPlaneta = SortiranaListaOdPlaneti[0]
            };

            soncev_sistem.PecatiPlaneti();
            Console.WriteLine();
            Console.WriteLine("Pecati so masa pogolena od 1 kg :");
            soncev_sistem.PecatiSoMasa(1f);
        }
    }
    public class Planeta
    {
        public string Ime { get; set; }
        public int Dijametar { get; set; }
        public int Oddalecenost { get; set; }
        public float Masa { get; set; }
        public Planeta()
        {

        }
        public Planeta(string ime, int dijametar, int oddalecenost, float masa)
        {
            Ime = ime;
            Dijametar = dijametar;
            Oddalecenost = oddalecenost;
            Masa = masa;
        }
        public void Pecati()
        {
            Console.WriteLine($"{Ime} so dijametar {Dijametar} km.");
        }
    }
    public class SoncevSistem
    {
        public Planeta NajbliskaPlaneta { get; set; }
        public List<Planeta> Planeti { get; set; }
        public SoncevSistem()
        {

        }
        public SoncevSistem(Planeta planeta, List<Planeta> listaNaPlaneti)
        {
            NajbliskaPlaneta = planeta;
            Planeti = listaNaPlaneti;
        }
        public void PecatiPlaneti()
        {
            foreach (var planeta in Planeti)
            {
                planeta.Pecati();
            }
            Console.WriteLine();
            Console.WriteLine($"Najbliska planeta e : {NajbliskaPlaneta.Ime} so dijametar {NajbliskaPlaneta.Dijametar} km. ");
        }
        public void PecatiSoMasa(float masa)
        {
            foreach (var planeta in Planeti) 
            {
                if (planeta.Masa > masa)
                {
                    planeta.Pecati();
                }
            }    
        }
    }
}
    
