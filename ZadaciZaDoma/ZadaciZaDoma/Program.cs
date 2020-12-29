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
                Console.WriteLine("Odberete zadaca:");
                Console.WriteLine();
                Console.WriteLine("1. Tocka ");
                Console.WriteLine("2. Kupuvacka Kosnicka ");
                Console.WriteLine("3. Agol ");
                Console.WriteLine("4. krug ");
                Console.WriteLine();

                var vnes = Console.ReadLine();
                Console.WriteLine(); 

                switch (vnes)
                {
                    case "1":
                        new PrvaZadaca().RunPrvaZadaca();
                        break;
                    case "2":
                        new VtoraZadaca().RunVtoraZadaca();
                        break;
                    case "3":
                        new TretaZadaca().RunTretaZadaca();
                        break;
                    case "4":
                        new CetvrtaZadaca().RunCetvrtaZadaca();
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