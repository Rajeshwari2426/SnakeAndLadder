using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder ");
            int player1 = 0;
            const int noPlay = 0;
            const int snake = 1;
            const int ladder = 2;
            string nxtMove = "Next move";


            Random random = new Random();
            int diceCount = random.Next(1, 7);
            int option = random.Next(0, 3);

            switch (option)
            {
                case noPlay:
                    // Do Nothing
                    nxtMove = "No Play";
                    break;

                case snake:
                    if (player1 > 0)
                        nxtMove = "Snake";
                    player1 = player1 - diceCount;
                    break;

                case ladder:
                    nxtMove = "Ladder";
                    player1 = player1 + diceCount;
                    break;

            }

            Console.WriteLine($"Dice Count: {diceCount}, Option: {nxtMove}, PlayerScore: {player1}");



            Console.ReadLine();

        }
    }
}
