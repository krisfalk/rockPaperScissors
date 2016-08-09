using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        int round;
        int numRounds;

        public Game()
        {
            Console.WriteLine("Enter name for player one:");
            this.playerOne = new Player(Console.ReadLine());
            Console.WriteLine("Enter name for player two:");
            this.playerTwo = new Player(Console.ReadLine());
            Console.WriteLine("How many rounds do you want to play?");
            numRounds = Convert.ToInt32(Console.ReadLine());
            this.round = 1;
            
        }
        public void RunGame()
        {
            while (round <= numRounds)
            {
                Console.WriteLine(playerOne.getName() + " do you want to pick rock, paper, or scissors?");
                playerOne.setOption(Console.ReadLine());
                Console.WriteLine(playerTwo.getName() + " do you want to pick rock, paper, or scissors?");
                playerTwo.setOption(Console.ReadLine());

                if (compare(playerOne.getOption(), playerTwo.getOption()) == 1)
                {
                    round++;
                    playerOne.addOneToScore();
                    Console.WriteLine(playerOne.getName() + " WINS");
                }
                else if (compare(playerOne.getOption(), playerTwo.getOption()) == 2)
                {
                    round++;
                    playerTwo.addOneToScore();
                    Console.WriteLine(playerTwo.getName() + " WINS");
                }
                else
                {
                    Console.WriteLine("TIE, try again.");
                }
            }
            Console.WriteLine("Final Score:\n" + playerOne.getName() + " {0}\n" + playerTwo.getName() + " {1}\n", playerOne.getScore(), playerTwo.getScore());
        }
        public int compare(string one, string two)
        {
            if(one == two)
            {
                return 3;
            }
            if(one == "rock")
            {
                if(two == "paper")
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }else if(one == "paper")
            {
                if(two == "scissors")
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }else if(one == "scissors")
            {
                if(two == "rock")
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            return 3;
        } 
    }
}
