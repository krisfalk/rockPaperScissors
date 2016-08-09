using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Welcome to the game of Rock, Paper, Scissors!!\n");
            game.RunGame();
            Console.WriteLine("Game Over.\nPlease play again!!\npress enter to exit");
            Console.ReadLine();
        }
    }
}
