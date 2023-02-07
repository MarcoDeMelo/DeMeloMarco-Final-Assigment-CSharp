using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2MarcoDeMelo
{
    class Player
    {
        public string playerName { get; set; }
        public int playerScore { get; set; }
        public int numberOfWins { get; set; }
        public int numberOfLosses { get; set; }

        
        public Player(string initialnameOfPlayer)
        {
            
            playerScore = 0;
            numberOfWins = 0;
            numberOfLosses = 0;
            playerName = initialnameOfPlayer;
            
            

        }
    }

   
}
