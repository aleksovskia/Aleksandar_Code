using System;
using System.Collections.Generic;

namespace NbaPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var Player1 = new NbaPlayer("Lonzo_Ball", "Los_Angeles_Lakers", 40.3, 6.1, 10.6);
            var Player2 = new NbaPlayer("Nikola_Jokic", "Denver_Nuggets", 10.2, 7.2, 9.6);
            var Player3 = new NbaPlayer("Donovan_Mitchell", "Utah_Jazz", 20.4, 3.6, 3.7);
            var Player4 = new NbaPlayer("Ben_Simmons", "Philadelphia_76ers", 16, 8.2, 8.2);
            var Player5 = new NbaPlayer("Kristaps_Porzingis", "NewYork_Knicks", 22.7, 1.2, 6.6);
            
            var allStarPlayer1 = new AllStarPlayer(Player1, 2, 3, 4);
            var allStarPlayer2 = new AllStarPlayer(Player2, 5, 6, 7);
            var allStarPlayer3 = new AllStarPlayer(Player3, 2, 3, 4);
            var allStarPlayer4 = new AllStarPlayer(Player1, 5, 3, 8);
            var allStarPlayer5 = new AllStarPlayer(Player1, 1, 3, 4);
            //Player1.Pecati();
            //allStarPlayer1.Pecati();
            //llStarPlayer2.Pecati();

            var ListaNaAllStar = new List<AllStarPlayer>() {allStarPlayer1,allStarPlayer2,allStarPlayer3,allStarPlayer4,allStarPlayer5};
           // var ListaNANbaPayer = new List<NbaPlayer>() { Player1, Player2, Player3, Player4, Player5};
           // foreach (var igraciNba in ListaNANbaPayer)
           // {
           //     igraciNba.Pecati();
           //     Console.WriteLine();
           // }
           // Console.WriteLine();
            foreach (var igraci in ListaNaAllStar)
            {
                igraci.Pecati();
                Console.WriteLine();
            }
        }
    }
    public class NbaPlayer
    {
        public string Ime { get; set; }
        public string Tim { get; set; }
        public double ProsecenBrojPoeni { get; set; }
        public double ProsecenBrojAsistencii { get; set; }
        public double ProsecenBrojSkokovi { get; set; }
        public NbaPlayer()
        {

        }
        public NbaPlayer(string ime,string tim,double prosecenBrojPoeni,double prosecenBrojAsistencii,double prosecenBrojSkokovi)
        {
            Ime = ime;
            Tim = tim;
            ProsecenBrojPoeni = prosecenBrojPoeni;
            ProsecenBrojAsistencii = prosecenBrojAsistencii;
            ProsecenBrojSkokovi = prosecenBrojSkokovi;
        }
        public virtual double Reiting()
        {
            
            var reiting = (ProsecenBrojPoeni * 45 / 100)+(ProsecenBrojAsistencii * 30/100)+(ProsecenBrojSkokovi* 25/100);
            return reiting;
        }
        public virtual void Pecati()
        {
            Console.WriteLine($" Ime : {Ime} Ime na Timot : {Tim} Broj na poeni : {ProsecenBrojPoeni} Broj na Skokovi {ProsecenBrojSkokovi} Broj na Asistencii {ProsecenBrojAsistencii} --- Rejting {Reiting()}");
        }
    }
    public class AllStarPlayer : NbaPlayer
    {
        public double PoeniVoAllStar { get; set; }
        public double AsistenciiVoAllStar { get; set; }
        public double SkokoviVoAllStar { get; set;  }      
        public AllStarPlayer()
        {
           
        }
        public AllStarPlayer( NbaPlayer igrac,double poeniVoAllStar,double asistenciiVoAllStar, double skokoviVoallStar)
            : base(igrac.Ime, igrac.Tim, igrac.ProsecenBrojPoeni,igrac.ProsecenBrojAsistencii,igrac.ProsecenBrojSkokovi)
        {

            PoeniVoAllStar = poeniVoAllStar;
            AsistenciiVoAllStar = asistenciiVoAllStar;
            SkokoviVoAllStar = skokoviVoallStar;
 
        }
        public AllStarPlayer(string ime, string tim, double prosecenBrojPoeni, double prosecenBrojAsistencii, double prosecenBrojSkokovi, double poeniVoAllStar, double asistenciiVoAllStar, double skokoviVoallStar)
           : base(ime,tim,prosecenBrojPoeni,prosecenBrojAsistencii,prosecenBrojSkokovi)
        {
            Ime = ime;
            Tim = tim;
            ProsecenBrojPoeni = prosecenBrojPoeni;
            ProsecenBrojAsistencii = prosecenBrojAsistencii;
            ProsecenBrojSkokovi = prosecenBrojSkokovi;
            PoeniVoAllStar = poeniVoAllStar;
            AsistenciiVoAllStar = asistenciiVoAllStar;
            SkokoviVoAllStar = skokoviVoallStar;
        }
        public  double AllStarReiting()
        {
            var allStarReiting = (PoeniVoAllStar * 30 / 100) + (AsistenciiVoAllStar * 40 / 100) + (SkokoviVoAllStar * 30 / 100);
            return allStarReiting;
        }
        public override double Reiting()
        {
          //  NEDORESENA !!!
          // koj go vrrakja prosekot od obicniot rejting na kosarkarot i rejtingot na All Start rejting .
          // Console.WriteLine($"new reating {base.Reiting()} All Star Reiting : {AllStarReiting()}");
            return base.Reiting();
        }
        public override void Pecati()
        {
            base.Pecati();
            Console.WriteLine($"All star Reiting : {AllStarReiting()} New rwiting : {Reiting()}" );
        }
    }
}
