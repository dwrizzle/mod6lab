using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mod6Lab
{
    internal class Player
    {
        private string name;
        private int score;
        private int livesLeft;
        public Player()
        {
            //intialization code that takes zero arguments
        }
              
        public Player(string name)
        {
            this.name = name;
        }
        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }
        public int GetScore()
        {
            return score;
        }
        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }
        public void Kill()
        {
            //We make sure they can't get negative lives.
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }
        public int GetLivesLeft()
        {
            return livesLeft;
        }
    }
}