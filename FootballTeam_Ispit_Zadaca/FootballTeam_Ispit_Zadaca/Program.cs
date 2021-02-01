using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam_Ispit_Zadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            var tim1 = new FootbaalTeam("Aleksandar", "Aleksovski", new List<int> { 7, 5, 5 },2.0);
            var tim2 = new FootbaalTeam("Viktor", "Nikolovski", new List<int> { 6, 4, 1 }, 2.0);
            var tim3 = new FootbaalTeam("Martin", "Martinovski", new List<int> { 5, 9, 3 }, 2.0);
            var tim4 = new FootbaalTeam("Nikola", "Petrovskii", new List<int> { 4, 7, 8 }, 2.0);
            var tim5 = new FootbaalTeam("Pero", "Spasevski", new List<int> { 3, 2, 4 }, 2.0);
            var tim6 = new FootbaalTeam("Stole", "Stolevski", new List<int> { 2, 1, 8 }, 2.0);
            var tim7 = new FootbaalTeam("Ilija", "Mitrovski", new List<int> { 1, 2, 5 }, 2.0);

            FootbaalTeam team1 = new Club (tim1,"Vardar" ,3);
            FootbaalTeam team2 = new Club(tim2, "vardar", 4);
            FootbaalTeam team3 = new Club(tim3, "vardar", 5);
            FootbaalTeam team4 = new Club(tim4, "vardar", 6);
            FootbaalTeam team5 = new NatoinalTeam(tim5, "Makedonija", 7);
            FootbaalTeam team6 = new NatoinalTeam(tim6, "Makedonija", 8);
            FootbaalTeam team7 = new NatoinalTeam(tim7, "Makedonija", 9);

            var ListaNaTimovi = new List<FootbaalTeam>() {team1,team2,team3,team4,team5,team6,team7};
            Console.WriteLine("Najgolemo dostignuvanje");
            var greatestAchieevement = ListaNaTimovi.OrderByDescending(x => x.Dostignuvanje).ToList();
            foreach (var timovi in greatestAchieevement)
            {
                Console.WriteLine();
                timovi.Pecati();
            }
            FootbaalTeam count = new FootbaalTeam ();
            count.ListaNaTimovi = new List<FootbaalTeam>() { team1, team2, team3, team4, team5, team6, team7 };
            Console.WriteLine();
            count.ListaTimovi();
        }
    }
    public  class FootbaalTeam
    {
        public string ImeTrener { get; set; }
        public string PrezimeTrener { get; set; }
        public List<int> Golovi { get; set; } // = new List<int>();

        public List<FootbaalTeam> ListaNaTimovi = new List<FootbaalTeam>();
        public double Dostignuvanje { get; set; }

        public double Koeficient = 2.0;
        public FootbaalTeam()
        {

        }
        public FootbaalTeam(string imeTrener, string prezimeTrener,List<int> golovi,double koeficient )
        {
            ImeTrener = imeTrener;
            PrezimeTrener = prezimeTrener;
            Golovi = golovi;
            Koeficient = koeficient;
        }
        public int BrojNaGolovi()
        {
            var brojNaGolovi = 0;
            foreach (var gol in Golovi)
            {
                brojNaGolovi += gol;
            }
            return brojNaGolovi;
        }
        public virtual double PromenaKoeficient() //Megjunarodna Fudbalska Federacija
        {
            //Koeficient = 2;
            //Koeficient = koeficientPromena - 1.0;
            return Koeficient;
        }
        public virtual double Achievement()
        {

            return Dostignuvanje;
        }
        public virtual void Pecati() // Testtiranje
        {
            Console.WriteLine($" Ime : {ImeTrener} Prezime : {PrezimeTrener} Golovi : {BrojNaGolovi()} ");
        }
        public void ListaTimovi()
        {
            var club = 0;
            var nacionalTeam = 0;
            foreach (var klubovi in ListaNaTimovi)
            {
                if (klubovi is Club)
                {
                    club++;
                }
                if (klubovi is NatoinalTeam)
                {
                    nacionalTeam++;
                }
            }
            Console.WriteLine($"Club: {club}\nNacional Team: {nacionalTeam}");
        }   
    }
    public class Club : FootbaalTeam
    {
        public string ImeNaKlubot { get; set; }
        public int BrojNaMedalji { get; set; }
        public Club()
        {

        }
        public Club (FootbaalTeam Team, string imeNaKlubot,int brojNaMedalji )
            : base(Team.ImeTrener,Team.PrezimeTrener,Team.Golovi,Team.Koeficient)
        {
            ImeNaKlubot = imeNaKlubot;
            BrojNaMedalji = brojNaMedalji;
        }
        public Club(string imeTrener, string prezimeTrener, List<int> golovi,string imeNaKlubot,int brojNaMedalji, double koeficient)
            :base(imeTrener, prezimeTrener,golovi,koeficient)
        {
            ImeTrener = imeTrener;
            PrezimeTrener = prezimeTrener;
            Golovi = golovi;
            ImeNaKlubot = imeNaKlubot;
            BrojNaMedalji = brojNaMedalji;
        }
        public override double Achievement()
        {
           var Dostignuvanje = (BrojNaGolovi() * Koeficient) + BrojNaMedalji;
            return Dostignuvanje;
        }
        public override void Pecati()
        {
            base.Pecati();
            Console.WriteLine($" Ime na klubot : {ImeNaKlubot} Dostignuvanje : {Achievement()}");
        }
    }
    public class NatoinalTeam : FootbaalTeam
    {
        public string Drzava { get; set; }
        public int MegunarodniNastapi { get; set; }
        
        public NatoinalTeam()
        {

        }
        public NatoinalTeam(FootbaalTeam tim, string drzava,int megunarodniNastapi)
            : base(tim.ImeTrener, tim.PrezimeTrener, tim.Golovi,tim.Koeficient)
        {
            Drzava = drzava;
            MegunarodniNastapi = megunarodniNastapi;
        }
        public NatoinalTeam(string imeTrener, string prezimeTrener, List<int> golovi, double koeficient,string drzava,int megunarodniNastapi, double dostignuvanje)
        {
            ImeTrener = imeTrener;
            PrezimeTrener = prezimeTrener;
            Golovi = golovi;
            Koeficient = koeficient;
            Drzava = drzava;
            MegunarodniNastapi = megunarodniNastapi;
            Dostignuvanje = dostignuvanje;
        }
        public override double Achievement()
        {
            var Dostignivanje = (BrojNaGolovi() * Koeficient) + MegunarodniNastapi;
            return Dostignivanje;
        }
        public override void Pecati()
        {
            base.Pecati();
            Console.WriteLine($"Ime na Drzavata : {Drzava} Dostignuvanje : {Achievement()}");
        }
    }
}
