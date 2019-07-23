using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
//Plan: put a picture box with 6 dice pictures
//use random class to show the picture of the dice each time the roll is complete on the button
//do while loop to keep playing the game
//have a user and a computer
//write results to game_results.txt file that prints the amount of wins by the player and computer
//and amount of ties


namespace Dice_Simulator
{
    public partial class frmDiceSimulator : Form
    {
        

        public frmDiceSimulator()
        {
            InitializeComponent();
        }

         
    
        private void btnUser_Click(object sender, EventArgs e)
        {
           

            //variables for keeping track number of wins and ties
            int computerWins = 0;
            int userWins = 0;
            int numberOfTies = 0;

            //total variables
            int UserTotal = 0;
            int computerTotal = 0;

           
                //an object made for the random class
                Random rand = new Random();
           
            //initialize variables
            int dice1 = new int();

            int dice2 = new int();

            int dice3 = new int();

            int dice4 = new int();                    
       
            
            //if statments for the first dice and the user
            dice1 = rand.Next(6) + 1;
            if (dice1 == 0)
            {
                picUser1.Image = Properties.Resources.DiceOne;
                dice1++;

            }

            else if (dice1 == 1)
            {

                picUser1.Image = Properties.Resources.DiceTwo;
                dice1++;
            }

            else if(dice1 == 2)
            {
                picUser1.Image = Properties.Resources.DiceThree;
                dice1++;
            }

            else if(dice1 == 3)
            {
                picUser1.Image = Properties.Resources.DiceFour;
                dice1++;
            }

            else if(dice1 == 4)
            {
                picUser1.Image = Properties.Resources.DiceFive;
                dice1++;
            }

            else 
            {
                dice1 = 5;
                picUser1.Image = Properties.Resources.DiceSix;
                dice1++;
            }


            //if statments for the secound dice and the user
            dice2 = rand.Next(6) + 1;

            if (dice2 == 0)
            {
                picUser2.Image = Properties.Resources.DiceOne;
                dice2++;
            }

            else if(dice2 == 1)
            {
                picUser2.Image = Properties.Resources.DiceTwo;
                dice2++;
            }
            
            else if(dice2 == 2)
            {
                picUser2.Image = Properties.Resources.DiceThree;
                dice2++;
            }

            else if(dice2 == 3)
            {

                picUser2.Image = Properties.Resources.DiceFour;
                dice2++;
            }
           
            else if(dice2 == 4)
            {
                picUser2.Image = Properties.Resources.DiceFive;
                dice2++;

            }

            else 
            {
                dice2 = 5;
                picUser2.Image = Properties.Resources.DiceSix;
                dice2++;

            }

            dice3 = rand.Next(6) + 1;
            //if statments for the secound dice and the computer
            if (dice3 == 0)
            {

                picComputer1.Image = Properties.Resources.DiceOne;
                dice3++;
            }

            else if(dice3 == 1)
            {
                picComputer1.Image = Properties.Resources.DiceTwo;
                dice3++;
            }

            else if(dice3 == 2)
            {
                picComputer1.Image = Properties.Resources.DiceThree;
                dice3++;
            }

            else if(dice3 == 3)
            {

                picComputer1.Image = Properties.Resources.DiceFour;
                dice3++;
            }

            else if(dice3 == 4)
            {

                picComputer1.Image = Properties.Resources.DiceFive;
                dice3++;

            }

            else 
            {
                dice3 = 5;
                picComputer1.Image = Properties.Resources.DiceSix;
                dice3++;
            }

            dice4 = rand.Next(6) + 1;
            //if statments for the secound dice and the computer
            if (dice4 == 0)
            {
                picComputer2.Image = Properties.Resources.DiceOne;
                dice4++;
            }

            else if (dice4 == 1)
            {
                picComputer2.Image = Properties.Resources.DiceTwo;
                dice4++;
            }

            else if (dice4 == 2)
            {

                picComputer2.Image = Properties.Resources.DiceThree;
                dice4++;
            }

            else if (dice4 == 3)
            {

                picComputer2.Image = Properties.Resources.DiceFour;
                dice4++;
            }

            else if(dice4 == 4)
            {

                picComputer2.Image = Properties.Resources.DiceFive;
                dice4++;
            }

            else
            {
                dice4 = 5;
                picComputer2.Image = Properties.Resources.DiceSix;
                dice4++;
            }

            UserTotal = dice1 + dice2;
            computerTotal = dice3 + dice4;


            if (UserTotal > computerTotal)
            {

                userWins++;

                //display results
                txtResults.Text = "YOU WIN";

            }

            else if (UserTotal == computerTotal)
            {

                numberOfTies++;
                txtResults.Text = "TIE GAME";
            }

            else if (UserTotal < computerTotal)
            {

                computerWins++;
                txtResults.Text = "COMPUTER WINS";

            }//end else


            try
            {

                //StreamWriter is the object for the outputFile
                StreamWriter outputFile;
                outputFile = File.CreateText("E:/c#/hw/Dice Simulator/game_results.txt");
                outputFile.WriteLine();
                outputFile.WriteLine("Number of wins by user is " + userWins);
                outputFile.WriteLine("Number of wins by computer is " + computerWins);
                outputFile.WriteLine("Number of ties is " + numberOfTies);
                outputFile.WriteLine();
                outputFile.Close();


            }//end try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }//end catch           


        }//end btnUser click event


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }//end btnExit click event

    }//end class

}//end namespace
