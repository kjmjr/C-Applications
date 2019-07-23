using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//notes
//have a random number generator for the computer
//1 - paper
//2- rock
//3 - scissors
//have a method that randomly assigns computer to a roll
//with a few if and else if statements
//make a function for paper/ rock/ scissors
//then let the user click the button to choose his option
//with a few if and else if statements
//make a function for paper/ rock/ scissors
//then click the see who won button to see who wins
namespace RockPaperScissors
{
    public partial class frmRockPaperScisscors : Form
    {
        public frmRockPaperScisscors()
        {
            InitializeComponent();
        }

      
          
        private void btnResults_Click(object sender, EventArgs e)
        {

            int paper = new int();
            int rock = new int();
            int scissors = new int();

            paper = 0;
            rock = 1;
            scissors = 2;

            if (paper == 0)         
            {

                picPaper.Image = Properties.Resources.Paper;

                if (randomComputerChoice() == 0)
                {
                    txtUserChoice.Text = "Paper";
                    txtComputerChoice.Text = "Paper";
                    txtResults.Text = "Tie Game, Play again";

                }

                else if (randomComputerChoice() == 1)
                {

                    txtUserChoice.Text = "Paper";
                    txtComputerChoice.Text = "Rock";
                    txtResults.Text = "User wins" + "\nPaper wraps Rock";
                }

                else
                {
                    txtUserChoice.Text = "Paper";
                    txtComputerChoice.Text = "Scissors";
                    txtResults.Text = "Computer wins" + "\nScissors cut Paper";

                }


            }
            else if (rock == 1)
            {

                picRock.Image = Properties.Resources.Rock;

                if (randomComputerChoice() == 0)
                {
                    txtUserChoice.Text = "Rock";
                    txtComputerChoice.Text = "Paper";
                    txtResults.Text = "Computer wins" + "\nPaper wraps Rock";

                }

                else if (randomComputerChoice() == 1)
                {

                    txtUserChoice.Text = "Rock";
                    txtComputerChoice.Text = "Rock";           
                    txtResults.Text = "Tie Game, Play again";
                }

                else
                {

                    txtUserChoice.Text = "Rock";
                    txtComputerChoice.Text = "Scissors";
                    txtResults.Text = "User wins" + "\nRock smashes Scissors";

                }

            }

            else if(scissors == 2)
            {

                picScissors.Image = Properties.Resources.Scissors;

                if (randomComputerChoice() == 0)
                {
                    txtUserChoice.Text = "Scissors";
                    txtComputerChoice.Text = "Paper";
                    txtResults.Text = "User wins" + "\nScissors cut Paper";


                }

                else if (randomComputerChoice() == 1)
                {
                    txtUserChoice.Text = "Scissors";
                    txtComputerChoice.Text = "Rock";
                    txtResults.Text = "Computer wins" + "\nRock smashes Scissors";

                }

                else
                {
                    txtUserChoice.Text = "Scissors";
                    txtComputerChoice.Text = "Scissors";             
                    txtResults.Text = "Tie Game, Play again";

                }


            }

            else
            {

                txtUserChoice.Text = "Please select a picture";
            }
            

        }//end of btnResults method

        

        private int randomComputerChoice()
        {
            Random rand = new Random();

            int choice = new int();

            choice = rand.Next(3) + 1;

            //if/ else if statements for the computers assignment
            if (choice == 0)
            {
                picPaper.Image = Properties.Resources.Paper;
                
            }

            else if (choice == 1)
            {
                picRock.Image = Properties.Resources.Rock;

            }

            else
            {
                picScissors.Image = Properties.Resources.Scissors;

            }

            return choice;

        }

        
    }//end class
}//end namespace
