using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        public int player;
        public const int noPlay = 0;
        public const int snake = 1;
        public const int ladder = 2;
       public int trials = 0;
       public string nxtMove = "Next move";

       Random random = new Random();
        public int PlayGame()
        { 

            while (player < 100)
            {
                int diceCount = random.Next(1, 7);
                int option = random.Next(0, 3);

                switch (option)
                {
                    case noPlay:                 
                        nxtMove = "No Play";
                        break;

                    case snake:
                        if (player > 0)
                        {
                            nxtMove = "Snake";
                            if ((player - diceCount) < 0)
                                player = 0;
                            else
                                player -= diceCount;
                        }
                        break;

                    case ladder:
                        nxtMove = "Ladder";
                        if (player + diceCount <= 100)
                            player += diceCount;
                        break;
                }
                trials++;
                Console.WriteLine($"Trial: {trials}, Dice Count: {diceCount}, Option: {nxtMove}, PlayerScore: {player}");
            }
            return trials;
        }
          static void Main(string[] args)
          {
            Program gamePlay1 = new Program ();
            int player1Trials = gamePlay1.PlayGame();

            Program gamePlay2 = new Program();
            int player2Trials = gamePlay2.PlayGame();

            if (player1Trials < player2Trials)
                Console.WriteLine($"Player1 - {player1Trials} attempts, Player2 - {player2Trials} attempts \n Player1 is the Winner");
            else if (player1Trials > player2Trials)
                Console.WriteLine($"Player1 - {player1Trials} attempts, Player2 - {player2Trials} attempts \n Player2 is the Winner");
            else
                Console.WriteLine("Its a Tie");


            Console.ReadLine();

          }
    }
}
