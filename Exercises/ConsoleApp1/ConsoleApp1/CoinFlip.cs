using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CoinFlip
    {
        public CoinFlip()
        {
            bool winGame = false;
            while (!winGame)
            {
                Random rnd = new();
                Console.WriteLine("Chose heads or Tails");
                string? chosenSide = Console.ReadLine();

                if (chosenSide == null || chosenSide == "")
                {
                    Console.WriteLine("You need to answer!");
                    Environment.Exit(0);

                }
                string flipSide = (rnd.Next(0, 2) == 1) ? "heads" : "tails";

                winGame = chosenSide.Trim().Equals(flipSide, StringComparison.CurrentCultureIgnoreCase);

                Console.WriteLine($"You choose: {chosenSide} and bot choose: {flipSide}");
                if (winGame)
                {
                    Console.WriteLine($"You Won!");
                }
                else
                {
                    Console.WriteLine($"You Lost!");

                }
            }
        }
    }
}
