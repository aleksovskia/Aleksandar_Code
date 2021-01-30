using System;
using System.Collections.Generic;
using System.Linq;

namespace SportskiEkipi
{
    class Program
    {
        static void Main(string[] args)
        {  
                var ManchesterUnited = new FudbalskaEkipa()
                {
                    // Odigrani Natprevari = 14
                    Ime = "Manchester United",
                    BrojNaPobedi = 5,
                    BrojNaPorazi = 3,
                    VkupenBrojNaCrveniKartoni = 3,
                    VkupenBrojNaZoltiKartoni = 7,
                    BrojNaNereseniNatprevari = 6
                };
                var Liverpool = new FudbalskaEkipa()
                {
                    // Odigrani Natprevari = 14
                    Ime = "Liverpool",
                    BrojNaPobedi = 6,
                    BrojNaPorazi = 2,
                    VkupenBrojNaCrveniKartoni = 3,
                    VkupenBrojNaZoltiKartoni = 7,
                    BrojNaNereseniNatprevari = 6
                };
                var Arsenal = new FudbalskaEkipa()
                {
                    // Odigrani Natprevari = 14
                    Ime = "Arsenal",
                    BrojNaPobedi = 4,
                    BrojNaPorazi = 4,
                    VkupenBrojNaCrveniKartoni = 3,
                    VkupenBrojNaZoltiKartoni = 7,
                    BrojNaNereseniNatprevari = 6
                };

            var ListaNaEkipi = new List<FudbalskaEkipa>() { ManchesterUnited, Liverpool, Arsenal };
            var SortiranaPoBrojNaPobedi = ListaNaEkipi.OrderByDescending(x => x.BrojNaPobedi).ToList();

            Console.WriteLine(" Site Ekipi podredeni po broj na osvoeni poeni : ");
            Console.WriteLine();
            foreach (var ekipa in SortiranaPoBrojNaPobedi )
            {
                ekipa.Pecati();
                Console.WriteLine();
            }
        }
    }
    public class Ekipa
    {
        public string Ime { get; set; }
        public int BrojNaPorazi { get; set; }
        public int BrojNaPobedi { get; set; }
        public Ekipa(string ime, int brojNaPorazi, int brojNaPobedi)
        {
            Ime = ime;
            BrojNaPorazi = brojNaPorazi;
            BrojNaPobedi = brojNaPobedi;
        }
        public Ekipa()
        {

        }
        public virtual void Pecati()
        {
            Console.WriteLine($" Ime : {Ime} Porazi : {BrojNaPorazi} Pobedi : {BrojNaPobedi}");
        }
    }
    public class FudbalskaEkipa : Ekipa
    {
       
        public int VkupenBrojNaCrveniKartoni { get; set; }
        public int VkupenBrojNaZoltiKartoni { get; set; }
        public int BrojNaNereseniNatprevari { get; set; }

        public FudbalskaEkipa()
        {

        }
        public FudbalskaEkipa(string ime, int brojNaPobedi, int BrojNaPorazi, int vkupenBrojNaCrveniKartoni, int vkupenBrojNaZoltiKartoni, int brojNaNereseniNatprevari)
            : base(ime, brojNaPobedi, BrojNaPorazi)
        {
            VkupenBrojNaCrveniKartoni = vkupenBrojNaCrveniKartoni;
            VkupenBrojNaZoltiKartoni = vkupenBrojNaZoltiKartoni;
            BrojNaNereseniNatprevari = brojNaNereseniNatprevari;
        }
        public override void Pecati()
        {
            base.Pecati();
            Console.WriteLine($" Nereseni : {BrojNaNereseniNatprevari} Poeni : {PresmetajPoeni()}");
        }
        public int PresmetajPoeni()
        {
            var poeni = 0;
            poeni += BrojNaPobedi * 3 + BrojNaNereseniNatprevari;
            return poeni;
        }
    }
}
