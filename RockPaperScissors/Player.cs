using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        string name;
        string option;
        int score;

        public Player(string name)
        {
            this.name = name;
        }
        public int getScore()
        {
            return this.score;
        }
        public void addOneToScore()
        {
            this.score += 1;
        }
        public string getName()
        {
            return this.name;
        }
        public void setOption(string option)
        {
            this.option = option;
        }
        public string getOption()
        {
            return option;
        }
    }
}
