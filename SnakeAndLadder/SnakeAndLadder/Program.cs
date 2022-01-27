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
            int trials = 0;
            string nxtMove = "Next move";


            Random random = new Random();

            while (player1 < 100)
            {
                int diceCount = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case noPlay:
                        
                        nxtMove = "No Play";
                        break;

                    case snake:
                        if (player1 > 0)
                        {
                            nxtMove = "Snake";
                            if ((player1 - diceCount) < 0)
                                player1 = 0;
                            else
                                player1 -= diceCount;
                        }
                        break;

                    case ladder:
                        nxtMove = "Ladder";
                        if (player1 + diceCount <= 100)
                            player1 += diceCount;
                        break;
                }
                trials++;
                Console.WriteLine($"Trial: {trials}, Dice Count: {diceCount}, Option: {nxtMove}, PlayerScore: {player1}");
            }


            Console.ReadLine();

        }
    }
}
