using System;

namespace Dogovor_
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dogovor();
            foreach (var dogovori in d.PotpisuvacDogovor)
            {
                Console.WriteLine(dogovori.EMBG + " " + dogovori.Ime + " " + dogovori.Prezime);
            }


            var potpisuvaciDogovor = d.PotpisuvacDogovor;
            bool isSame = false;
            int dogovorNumber = 0;
            for (int i = 0; i < potpisuvaciDogovor.Length; i++)
            {
                for (int j = 0; j < potpisuvaciDogovor.Length; j++)
                {
                    if (i != j && potpisuvaciDogovor[i].EMBG == potpisuvaciDogovor[j].EMBG)
                    {
                        isSame = true;
                        dogovorNumber = i + 1;
                        Console.WriteLine("Dogovor" + dogovorNumber);
                    }
                }
            }
            if (isSame == true) Console.WriteLine("Postojat potpishuvaci so ist EMBG");
    }
}
    public class Potpisuvac
    {
        public string Ime;
        public string Prezime;
        public string EMBG;

        public Potpisuvac()
        {
            Ime = "";
            Prezime = "";
            EMBG = "";
        }

    }

    public class Dogovor
    {
        public int BrojDogovor;
        public char[] KategorijaDogovor = new char[50];
        public Potpisuvac[] PotpisuvacDogovor = new Potpisuvac[3];

        public Dogovor()
        {
            BrojDogovor = 0;
            KategorijaDogovor[0] = 'a';
            
            PotpisuvacDogovor[0] = new Potpisuvac()
            {
                Ime = "Alek",
                Prezime = "Aleksov",
                EMBG = "0101988450001"
            };
            PotpisuvacDogovor[1] = new Potpisuvac()
            {
                Ime = "Alek",
                Prezime = "Aleksov",
                EMBG = "0101988450001"
            };
            PotpisuvacDogovor[2] = new Potpisuvac()
            {
                Ime = "Marko",
                Prezime = "Markov",
                EMBG = "0202987440022"
            };
        }

    }


        
    
}
