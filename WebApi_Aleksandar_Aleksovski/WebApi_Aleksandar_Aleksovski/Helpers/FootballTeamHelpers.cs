using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Aleksandar_Aleksovski.Helpers
{
    public class FootballTeamHelpers
    {
        public FootbaalTeam CreateFoodballTeam(string imeTrener)
        {
            var tim1 = new FootbaalTeam("Aleksandar", "Aleksovski", new List<int> { 7, 5, 5 });
            var tim2 = new FootbaalTeam("Viktor", "Nikolovski", new List<int> { 6, 4, 1 });
            var tim3 = new FootbaalTeam("Martin", "Martinovski", new List<int> { 5, 9, 3 });
            var tim4 = new FootbaalTeam("Nikola", "Petrovskii", new List<int> { 4, 7, 8 });
            var tim5 = new FootbaalTeam("Pero", "Spasevski", new List<int> { 3, 2, 4 });
            var tim6 = new FootbaalTeam("Stole", "Stolevski", new List<int> { 2, 1, 8 });
            var tim7 = new FootbaalTeam("Ilija", "Mitrovski", new List<int> { 1, 2, 5 });
          
            FootbaalTeam team1 = new Club(tim1, "Vardar", 3);
            FootbaalTeam team2 = new Club(tim2, "Rabotnicki", 4);
            FootbaalTeam team3 = new Club(tim3, "Pelister", 5);
            FootbaalTeam team4 = new Club(tim4, "Akademija Pandev", 6);
            FootbaalTeam team5 = new NatoinalTeam(tim5, "Makedonija", 7);
            FootbaalTeam team6 = new NatoinalTeam(tim6, "Srbija", 8);
            FootbaalTeam team7 = new NatoinalTeam(tim7, "Hrvatska", 9);     
            
            var ListaNaTimovi = new List<FootbaalTeam>() { team1, team2, team3, team4, team5, team6, team7 };
            foreach (var timovi in ListaNaTimovi)
            {
               // Console.WriteLine();
                timovi.Pecati();
            }
           // Console.WriteLine();
           // Console.WriteLine(" Najgolemo dostignuvanje :");
            var greatestAchieevement = ListaNaTimovi.OrderByDescending(x => x.Dostignuvanje).First();
            greatestAchieevement.Pecati();

            FootbaalTeam count = new FootbaalTeam();
            count.ListaNaTimovi = new List<FootbaalTeam>() { team1, team2, team3, team4, team5, team6, team7 };
           // Console.WriteLine();
            count.ListaTimovi();

            tim1.Dostignuvanje = team1.Dostignuvanje;
            tim2.Dostignuvanje = team2.Dostignuvanje;
            var foodbalTeam = new FootbaalTeam() {ImeTrener=imeTrener, ListaNaTimovi = new List<FootbaalTeam>() { tim1,tim2 } };
            return foodbalTeam;
        }
    }
    public class FootbaalTeam
    {
        public string ImeTrener { get; set; }
        public string PrezimeTrener { get; set; }
        public List<int> Golovi { get; set; } // = new List<int>();
        public List<FootbaalTeam> ListaNaTimovi { get; set; } // = new List<FootbaalTeam>();
        public double Dostignuvanje { get; set; }

        public double Koeficient = 2.0;
        public FootbaalTeam()
        {

        }
        public FootbaalTeam(string imeTrener, string prezimeTrener, List<int> golovi)
        {
            ImeTrener = imeTrener;
            PrezimeTrener = prezimeTrener;
            Golovi = golovi;
            Dostignuvanje = Achievement();
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
            Koeficient = 2.0;
            Koeficient = Koeficient + 0.0;
            return Koeficient;
        }
        public virtual double Achievement()
        {
            return Dostignuvanje;
        }
        public virtual string Pecati()
        {
            return $" Ime : {ImeTrener} Prezime : {PrezimeTrener} Golovi : {BrojNaGolovi()} ";
        }
        public virtual void ListaTimovi()
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
           // Console.WriteLine($"Club: {club}\nNacional Team: {nacionalTeam}");
        }
    }
    public class Club : FootbaalTeam
    {
        public string ImeNaKlubot { get; set; }
        public int BrojNaMedalji { get; set; }
        public Club()
        {

        }
        public Club(FootbaalTeam Team, string imeNaKlubot, int brojNaMedalji)
            : base(Team.ImeTrener, Team.PrezimeTrener, Team.Golovi)
        {
            ImeNaKlubot = imeNaKlubot;
            BrojNaMedalji = brojNaMedalji;
            Dostignuvanje = Achievement();
        }
        public Club(string imeTrener, string prezimeTrener, List<int> golovi, string imeNaKlubot, int brojNaMedalji, double koeficient)
            : base(imeTrener, prezimeTrener, golovi)
        {
            ImeTrener = imeTrener;
            PrezimeTrener = prezimeTrener;
            Golovi = golovi;
            ImeNaKlubot = imeNaKlubot;
            BrojNaMedalji = brojNaMedalji;
            Dostignuvanje = Achievement();
        }
        public override double Achievement()
        {
            var Dostignuvanje = (BrojNaGolovi() * PromenaKoeficient()) + BrojNaMedalji;
            return Dostignuvanje;
        }
        public override string Pecati()
        {
            base.Pecati();
           return $" Ime na klubot : {ImeNaKlubot} Dostignuvanje : {Achievement()}";
        }
    }
    public class NatoinalTeam : FootbaalTeam
    {
        public string Drzava { get; set; }
        public int MegunarodniNastapi { get; set; }
        public NatoinalTeam()
        {

        }
        public NatoinalTeam(FootbaalTeam tim, string drzava, int megunarodniNastapi)
            : base(tim.ImeTrener, tim.PrezimeTrener, tim.Golovi)
        {
            Drzava = drzava;
            MegunarodniNastapi = megunarodniNastapi;
            Dostignuvanje = Achievement();
        }
        public NatoinalTeam(string imeTrener, string prezimeTrener, List<int> golovi, double koeficient, string drzava, int megunarodniNastapi, double dostignuvanje)
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
            var Dostignivanje = (BrojNaGolovi() * PromenaKoeficient()) + MegunarodniNastapi;
            return Dostignivanje;
        }
        public override string Pecati()
        {
            base.Pecati();
          return $" Ime na Drzavata : {Drzava} Dostignuvanje : {Achievement()}";
        }
    }
}