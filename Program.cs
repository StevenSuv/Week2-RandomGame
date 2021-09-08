using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat
            //iga mängija viskab täringut (1-6)
            //programm kuvab nende visete tulemused ja kuvab ka, kes on võitja
            // - ehk kes viskas suurema

            Random rnd = new Random();

            string playerOne = "Hairy Pot";
            string playerTwo = "Voltorb";

            int HarryThrow = rnd.Next(1, 7);
            int VoldThrow = rnd.Next(1, 7);

            Console.WriteLine($"{playerOne} threw {HarryThrow};");
            Console.WriteLine($"{playerTwo} threw {VoldThrow};");

            if (HarryThrow > VoldThrow)
            {
                Console.WriteLine($"{playerOne} wins!");
            }
            else if (HarryThrow < VoldThrow)
            {
                Console.WriteLine($"{playerTwo} wins!");
            }
            else
            {
                Console.WriteLine("Draw! Let them try again.");
            }
        }
    }
}
