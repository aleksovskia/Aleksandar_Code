using System;

namespace ZadaciZaDoma
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------////");
                Console.WriteLine();
                Console.WriteLine("Odberete zadaca :");
                Console.WriteLine();
                Console.WriteLine("1. Tocka ");
                Console.WriteLine("2. Kupuvacka Kosnicka ");
                Console.WriteLine("3. Agol ");
                Console.WriteLine("4. krug ");
                Console.WriteLine("5. Ureduvanje na Dom " );
                Console.WriteLine("6. Employee " );
                Console.WriteLine();

                var vnes = Console.ReadLine();
                Console.WriteLine(); 

                switch (vnes)
                {
                    case "1":
                        new PrvaZadaca_Tocka().RunPrvaZadaca();
                        break;
                    case "2":
                        new VtoraZadaca_Kupuvacka_Kosnicka().RunVtoraZadaca();
                        break;
                    case "3":
                        new TretaZadaca_Agol().RunTretaZadaca();
                        break;
                    case "4":
                        new CetvrtaZadaca_Krug().RunCetvrtaZadaca();
                        break;
                    case "5":
                        new PetaZadaca_Ureduvanje_Dom().RunPetaZadaca();
                        break;
                    case "6":
                        new SestaZadaca_Employee().RunSestaZadaca();
                        break;


                    default:
                        Console.WriteLine("Pogresen vnes!");
                        break;
                }
                if (vnes == "exit")
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------////");
                
                Console.WriteLine();
            }
        }

    }
}