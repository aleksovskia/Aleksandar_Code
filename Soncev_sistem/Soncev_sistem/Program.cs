using System;
using System.Collections.Generic;

namespace Soncev_sistem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Site Planeti : ");
            Console.WriteLine();
            var planeta = new SoncevSistem();
            {
                planeta.NajbliskaPlaneta = new Planeta("Merkur", 4879, 57909227, 0.0553f);
                planeta.Planeti = "Site Planeti 1 ";
                planeta.BrojPlaneti = 1;
                planeta.PecatiPlaneti();

            }
            var planeta1 = new SoncevSistem();
            {
                planeta1.NajbliskaPlaneta = new Planeta("Venera", 12104, 108209475, 0.815f);
                planeta1.Planeti = "Site Planeti 2 ";
                planeta1.BrojPlaneti = 2;
                planeta1.PecatiPlaneti();

            }
            var planeta2 = new SoncevSistem();
            {
                planeta2.NajbliskaPlaneta = new Planeta("Zemja", 12742, 149598262, 1f);
                planeta2.Planeti = "Site Planeti 3 ";
                planeta2.BrojPlaneti = 3;
                planeta2.PecatiPlaneti();
            }
            var planeta3 = new SoncevSistem();
            {
                planeta3.NajbliskaPlaneta = new Planeta("Mars", 6779, 227943824, 0.11f);
                planeta3.Planeti = "Site Planeti 4 ";
                planeta3.BrojPlaneti = 4;
                planeta3.PecatiPlaneti();
            }
            var planeta4 = new SoncevSistem();
            {
                planeta4.NajbliskaPlaneta = new Planeta("Jupiter", 139822, 778340821, 317.8f);
                planeta4.Planeti = "Site Planeti 5 ";
                planeta4.BrojPlaneti = 5;
                planeta4.PecatiPlaneti();
            }
            var planeta5 = new SoncevSistem();
            {
                planeta5.NajbliskaPlaneta = new Planeta("Saturn", 116464, 1426666422, 95.2f);
                planeta5.Planeti = "Site Planeti 6 ";
                planeta5.BrojPlaneti = 6;
                planeta5.PecatiPlaneti();
            }
            var listaNaPlaneti = new List<SoncevSistem>() { planeta, planeta1, planeta2, planeta3, planeta4, planeta5 };
            NajbliskaPlaneta1(listaNaPlaneti, 100000000); // Najbliska planeta ---------------------------

            var pogolemaMasa = new List<SoncevSistem>() { planeta , planeta1, planeta2, planeta3, planeta4, planeta5 };
            ListaMasa(pogolemaMasa, 1);
        }
        public static void NajbliskaPlaneta1(List<SoncevSistem> planeti, int oddalecenost)
        {
            Console.WriteLine();
            Console.Write("----- Najbliska Planeta e : ");
            for (int i = 0; i < planeti.Count; i++)
            {
                if (planeti[i].NajbliskaPlaneta.Oddalecenost < oddalecenost)
                {
                    Console.WriteLine();
                    planeti[i].PecatiPlaneti();
                }
            }
        }
        public static void ListaMasa(List<SoncevSistem> planeti, float masa)
        {
            Console.WriteLine();
            Console.WriteLine("----- Planeti so pogolema masa od 1kg : ");
            for (int i = 0; i < planeti.Count; i++)
            {
                if (planeti[i].NajbliskaPlaneta.Masa > masa)
                {
                    planeti[i].PecatiSoMasa();
                }
            }
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
        public void Copy()
        {

        }
        public void Pecati()
        {
            Console.WriteLine($"{Ime} so dijametar {Dijametar} km.");
        }
    }
    public class SoncevSistem
    {
        public Planeta NajbliskaPlaneta;
        public string Planeti { get; set; }
        public int BrojPlaneti { get; set; }

        public SoncevSistem()
        {
            NajbliskaPlaneta = new Planeta();
            Planeti = " ";
            BrojPlaneti = 0;
        }
        public SoncevSistem(Planeta najbliskaPlaneta, string planeti, int brojplaneti)
        {
            NajbliskaPlaneta = najbliskaPlaneta;
            Planeti = planeti;
            BrojPlaneti = brojplaneti;

        }
        public SoncevSistem(string planeti, int brojPlaneti)
        {
            Planeti = planeti;
            BrojPlaneti = brojPlaneti;
        }
        public void PecatiPlaneti()
        {
            NajbliskaPlaneta.Pecati();

        }
        public void PecatiSoMasa()
        {
            NajbliskaPlaneta.Pecati();
        }
    }
}