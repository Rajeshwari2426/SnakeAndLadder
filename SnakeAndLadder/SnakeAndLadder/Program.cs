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
            Random random = new Random();
            int diceCount = random.Next(1, 7);

            Console.WriteLine(diceCount);
            Console.ReadLine();

        }
    }
}
