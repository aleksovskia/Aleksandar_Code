using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public abstract class FootbaalTeam
    {
        public string ImeTrener { get; set; }
        public string PrezimeTrener { get; set; }
        public List<int> Golovi { get; set; }   // = new List<int>();

        public double Koeficient = 2.0;

        public virtual double NovKoeficient()
        {
            return Koeficient;
        }


        public abstract int VkupenBrojGolovi();

        public abstract int Achievement();
       // public static bool VkupnoGolovi()
        
            
            
        
    }
    public class Club : FootbaalTeam
    {
        public string ImeNaKlubot { get; set; }
        public int BrojNaMedalji { get; set; }

        public Club()
        {

        }
        public Club(FootbaalTeam Team, string imeNaKlubot, int brojNaMedalji)
            : base(Team.ImeTrener, Team.PrezimeTrener, Team.Golovi, Team.Koeficient)
        {
            ImeNaKlubot = imeNaKlubot;
            BrojNaMedalji = brojNaMedalji;
        }
        public Club(string imeTrener, string prezimeTrener, List<int> golovi, double koeficient, string imeNaKlubot, int brojNaMedalji)
            : base(imeTrener, prezimeTrener, golovi, koeficient)
        {
            ImeTrener = imeTrener;
            PrezimeTrener = prezimeTrener;
            Golovi = golovi;
            Koeficient = koeficient;
            ImeNaKlubot = imeNaKlubot;
            BrojNaMedalji = brojNaMedalji;

        }
    }


   

}
