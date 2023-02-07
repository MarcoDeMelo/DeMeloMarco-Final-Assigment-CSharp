using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment2MarcoDeMelo
{
    public partial class Form1 : Form
    {
        Game game1;
        Player playerOne;
        Player playerTwo;
       
        
        public Form1()
        {
            InitializeComponent();
        }
    
        private void startButton_Click(object sender, EventArgs e)
        {
            playerOne = new Player(player1Box.Text);
            playerTwo = new Player(player2Box.Text);
            game1= new Game();
            targetWord.Text = generateHidden(game1.chosenWord.Count());
            pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.wheel;
            MessageBox.Show("Game is loading", "Please wait");
            //Add a timer here
            Thread.Sleep(2000);
            generatePlayerScorePic(game1.chosenWordValue);
            Random random = new Random();

            showTurn(game1.whosTurnIt = random.Next(0, 2));
            player1ScoreBox.Text = playerOne.playerScore.ToString();
            player2ScoreBox.Text = playerTwo.playerScore.ToString();



        }

        private void insertPrompt_Click(object sender, EventArgs e)
        {

        }

        private void player1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void guessWordButton_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult;
            generatePlayerScorePic(game1.chosenWordValue = new Game().chosenWordValue);
            targetWord.Text = compareWord(game1.chosenWord.Count(), playerGuessBox.Text,targetWord.Text);

            if (targetWord.Text.CompareTo(game1.chosenWord.ToLower()) == 0)
            {
                displayImage(game1.chosenWord);
                 
               
                if (playerOne.playerScore > playerTwo.playerScore)
                    dialogResult = MessageBox.Show("Would you like to play again?", "Congrats To Player 1 for winning", MessageBoxButtons.YesNo);
                else 
                    dialogResult = MessageBox.Show("Would you like to play again?", "Congrats To Player 2 for winning", MessageBoxButtons.YesNo);
                
                    if (dialogResult == DialogResult.Yes)
                    {
                        playerOne = new Player(player1Box.Text);
                        playerTwo = new Player(player2Box.Text);
                        game1 = new Game();
                        targetWord.Text = generateHidden(game1.chosenWord.Count());
                        pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.wheel;
                        MessageBox.Show("Game is loading", "Please wait");
                        //Add a timer here
                        Thread.Sleep(2000);
                        generatePlayerScorePic(game1.chosenWordValue);
                    Random random = new Random();

                    showTurn(game1.whosTurnIt = random.Next(0, 2));
                    player1ScoreBox.Text = playerOne.playerScore.ToString();
                    player2ScoreBox.Text = playerTwo.playerScore.ToString();
                }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Have a great day!", "OK!");
                        Environment.Exit(2);
                    }
                


            }
           
        }


        public string generateHidden(int length)
        {
            string chosenWord = "";

            for (int ctr = 0; ctr < length; ctr++)
            {
                chosenWord = chosenWord.Insert(ctr, "-");
            }

            return chosenWord;
        }
        public int generatePlayerScorePic(int value)
        {

            switch (value)
            {
                case 120:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._121;
                    break;
                case 1521:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._1521;
                    break;
                case 1:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._1;
                    break;
                case 31:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._31;
                    break;
                case 51:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._51;
                    break;
                case 61:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._61;
                    break;
                case 86:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._86;
                    break;
                case 96:
                    break;
                case 0:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._0;
                    break;
                case 10:
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources._10;
                    break;
                default:
                    MessageBox.Show("Error", "Error");
                    Environment.Exit(5);
                    break;

            }
            return game1.chosenWordValue;
        }
        public string compareWord(int length, string insertedLetter,string hiddenChosenWord)
        {
            
            
            char[] outcomeWord = hiddenChosenWord.ToCharArray();
            string chosenWord = game1.chosenWord.ToUpper();
            char[] chosenWordArray = chosenWord.ToUpper().ToCharArray();
            char[] compareLetter = insertedLetter.ToUpper().ToCharArray();
            bool workedOrNot = false;
            for (int ctr = 0; ctr < length; ctr++)
            {

                if (chosenWordArray[ctr] == compareLetter[0] )
                {
                    outcomeWord[ctr] = compareLetter[0];
                    workedOrNot = true;
                }
                

            }
            if (workedOrNot == true)
            {
                if (game1.whosTurnIt == 0)
                {
                    MessageBox.Show("You guessed a letter " + game1.chosenWordValue + " points for Player 1", "Congrats");
                    playerOne.playerScore += game1.chosenWordValue;
                    player1ScoreBox.Text = playerOne.playerScore.ToString();
                }
                else if (game1.whosTurnIt == 1)
                {
                    MessageBox.Show("You guessed a letter " + game1.chosenWordValue + " points for Player 2", "Congrats");
                    playerTwo.playerScore += game1.chosenWordValue;
                    player2ScoreBox.Text = playerTwo.playerScore.ToString();
                }
            }
            else
            {
                if (game1.whosTurnIt == 0)
                {
                    MessageBox.Show("You failed Player 2 turn now", "Wrong");
                    game1.whosTurnIt = 1;

                }
                else if (game1.whosTurnIt == 1)
                {
                    MessageBox.Show("You failed Player 1 turn now", "Wrong");
                    game1.whosTurnIt = 0;

                }
            }
            return hiddenChosenWord = new string(outcomeWord).ToLower();
        }
        public void showTurn(int turn)
        {
            if (turn == 0)
                MessageBox.Show("It's player 1 turn", "Who's Turn is it?");
            else
                MessageBox.Show("It's player 2 turn", "Who's Turn is it?");


        }
        public void displayImage(string chosenWord)
        {
            switch (chosenWord)
            {
                case "Cat":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.cat;
                        break;
                case "Gold":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.gold;
                    break;
                case "Raccoon":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.fatRaccoon;
                    break;
                case "Rock":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.rock;
                    break;
                case "WaterMelon":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.watermelon;
                    break;
                case "Socks":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.socks;
                    break;
                case "Smile":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.smileCat;
                    break;
                case "Insult":
                    pictureBoxWheel.Image = Assigment2MarcoDeMelo.Properties.Resources.lowInteligenceCat;
                    break;
                default:
                    MessageBox.Show("Error", "Error");
                    Environment.Exit(2);
                    break;


            }
        }

    }
}
