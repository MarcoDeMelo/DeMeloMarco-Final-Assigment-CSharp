using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2MarcoDeMelo
{
    class Game
    {
        
        public static string[] targetWords { get; set; } = new string[] { "Cat","Rock","Gold","Gum","Raccoon","WaterMelon","House","Socks","Smile","Insult"};
        public static int[] prizeAmount { get; set; } = new int[] { 120, 1521, 1, 31, 51, 61, 86, 96, 0, 10 }; //this has 10 Values
        public string chosenWord { get; set; }
        public int chosenWordValue { get; set; }
        
        public int whosTurnIt { get; set; }
       



        public Game()
        {
            
            chosenWord = targetWords[getRandNumber()];
            chosenWordValue = prizeAmount[getRandNumber()];
            whosTurnIt = whosTurnIt;
        }
         int getRandNumber()
        {
            Random random = new Random();
            return random.Next(0, 10);
            
        }
    
    
    
    }








 

}
