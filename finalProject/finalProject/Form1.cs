using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace finalProject
{

    public partial class wheelOfFortune : Form
    {
      
        public wheelOfFortune()
        {
            InitializeComponent();

            //calling void method to set the game up
            setGame();

            //hide buttons and messages on the load
            btnSpinPlayerTwo.Hide();
            btnSolvePlayerTwo.Hide();
            lblMessageTwo.Hide();

            btnSpinPlayerThree.Hide();
            btnSolvePlayerThree.Hide();
            lblMessageThree.Hide();

            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (char c in letters)
            {
                lstAvailableLetters.Items.Add(c);


            }//end foreach loop

            txtPlayerOne.Text = "$0";
            txtPlayerTwo.Text = "$0";
            txtPlayerThree.Text = "$0";
                
        }//end of load method 
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            MessageBox.Show("Thanks for playing the game Wheel of Fortune");

        }//end button exit method 


        private void btnSpinPlayerOne_Click(object sender, EventArgs e)
        {

            validatePlayerOneSpin();

           
            
        }//end spin method for player one

        private void btnSolvePlayerOne_Click(object sender, EventArgs e)
        {
            solver solverPlayerOne = new solver();        
            this.Hide();
            solverPlayerOne.Show();

        }//end solve method for player one



        private void btnSpinPlayerTwo_Click(object sender, EventArgs e)
        {

            validatePlayerTwoSpin();

        }//end spin method for player two

        private void btnSolvePlayerTwo_Click(object sender, EventArgs e)
        {
            solverTwo solverPlayerTwo = new solverTwo();       
            this.Hide();
            solverPlayerTwo.Show();


        }//end solve method for player two

        private void btnSpinPlayerThree_Click(object sender, EventArgs e)
        {

            validatePlayerThreeSpin();

        }//end spin method for player three

        private void btnSolvePlayerThree_Click(object sender, EventArgs e)
        {

            solverThree solverPlayerThree = new solverThree();          
            this.Hide();
            solverPlayerThree.Show();

        }//end solve method for player three


        public void setGame()
        {
                                                                    
            wheel player1 = new wheel();
            wheel player2 = new wheel();
            wheel player3 = new wheel();

            int total;

           //set money amount when program loads
            total = player1.getTotalMoney();

            //printing it back out from what was calculated
            txtPlayerOne.Text = "$" + total.ToString("n2");


            //set money amount when program loads
            total = player2.getTotalMoney();

            //printing it back out from what was calculated
            txtPlayerTwo.Text = "$" + total.ToString("n2");

            //set money amount when program loads
            total = player3.getTotalMoney();

            //printing it back out from what was calculated
            txtPlayerThree.Text = "$" + total.ToString("n2");


        }//end void method

       
        public void validatePlayerOneSpin()
        {

            //created object for the first player
            wheel player1 = new wheel();         
            guesser guesser1 = new guesser();
                             
            //get the spin to determine where numbers fall
            int p1Spin = player1.getSpin();
            int number = -1000;

            if (p1Spin == -1000)
            {
                MessageBox.Show("SORRY BUT YOUR SPIN LANDED ON -1000  " + "\nTHIS MEANS YOU LOST A TURN"
                    + "\nAND LOST $1000");

                //calculating total then returning it
                player1.calculateMoney(number);

                int total = player1.getTotalMoney();

                //printing it back out from what was calculated
                txtPlayerOne.Text = "$" + total.ToString("n2");

                MessageBox.Show("Next players turn");

              
                //hide buttons and messages on the load
                btnSpinPlayerOne.Hide();
                btnSolvePlayerOne.Hide();
                lblMessageOne.Hide();

                btnSpinPlayerTwo.Show();
                btnSolvePlayerTwo.Show();
                lblMessageTwo.Show();

                btnSpinPlayerThree.Hide();
                btnSolvePlayerThree.Hide();
                lblMessageThree.Hide();



            }//end if 

            else if (p1Spin == 0)
            {
                MessageBox.Show("SORRY BUT YOUR SPIN LANDED ON 0 " + "\nTHIS MEANS YOU LOST A TURN");

                number = 0;

                player1.calculateMoney(number);

                int total = player1.getTotalMoney();

                txtPlayerOne.Text = "$" + total.ToString("n2");


                MessageBox.Show("Next players turn");

             
                //hide buttons and messages on the load
                btnSpinPlayerOne.Hide();
                btnSolvePlayerOne.Hide();
                lblMessageOne.Hide();

                btnSpinPlayerTwo.Show();
                btnSolvePlayerTwo.Show();
                lblMessageTwo.Show();


                btnSpinPlayerThree.Hide();
                btnSolvePlayerThree.Hide();
                lblMessageThree.Hide();


            }//end else if

            else
            {
                number = 0;

                player1.calculateMoney(number);

                int total = player1.getTotalMoney();

                txtPlayerOne.Text = "$" + total.ToString("n2");

                MessageBox.Show("Your spin landed on $" + p1Spin + " dollars");

                this.Hide();
                guesser1.Show();
                
            }//end else 

           

        }//end void validation for first player

        public void validatePlayerTwoSpin()
        {

            wheel player2 = new wheel();
            guesserTwo guesser2 = new guesserTwo();
            int number = -1000;


            //get the spin to determine where numbers fall
            int p2Spin = player2.getSpin();


            if (p2Spin == -1000)
            {
                MessageBox.Show("SORRY BUT YOUR SPIN LANDED ON -1000  " + "\nTHIS MEANS YOU LOST A TURN"
                    + "\nAND LOST $1000");

                player2.calculateMoney(number);

                int total = player2.getTotalMoney();

                txtPlayerTwo.Text = "$" + total.ToString("n2");

                MessageBox.Show("Next players turn");

          
                //hide buttons and messages on the load
                btnSpinPlayerOne.Hide();
                btnSolvePlayerOne.Hide();
                lblMessageOne.Hide();

                btnSpinPlayerThree.Show();
                btnSolvePlayerThree.Show();
                lblMessageThree.Show();


                btnSpinPlayerTwo.Hide();
                btnSolvePlayerTwo.Hide();
                lblMessageTwo.Hide();

            }//end if 

            else if (p2Spin == 0)
            {
                MessageBox.Show("SORRY BUT YOUR SPIN LANDED ON 0 " + "\nTHIS MEANS YOU LOST A TURN");

                number = 0;

                player2.calculateMoney(number);

                int total = player2.getTotalMoney();

                txtPlayerTwo.Text = "$" + total.ToString("n2");

                MessageBox.Show("Next players turn");

               // txtPlayerThree.Focus();

                //hide buttons and messages on the load
                btnSpinPlayerOne.Hide();
                btnSolvePlayerOne.Hide();
                lblMessageOne.Hide();

                btnSpinPlayerThree.Show();
                btnSolvePlayerThree.Show();
                lblMessageThree.Show();

                btnSpinPlayerTwo.Hide();
                btnSolvePlayerTwo.Hide();
                lblMessageTwo.Hide();

            }//end else if

            else
            {
                number = 0;

                player2.calculateMoney(number);

                int total = player2.getTotalMoney();

                txtPlayerTwo.Text = "$" + total.ToString("n2");

                MessageBox.Show("Your spin landed on $" + p2Spin + " dollars");
                this.Hide();
                guesser2.Show();
              
            }//end else

            
        }//end void method validation for the second player

        public void validatePlayerThreeSpin()
        {
            wheel player3 = new wheel();
            guesserThree gusser3 = new guesserThree();
            int number = -1000;



            int p3Spin = player3.getSpin();

            if (p3Spin == -1000)
            {
                MessageBox.Show("SORRY BUT YOUR SPIN LANDED ON -1000 " + "\nTHIS MEANS YOU LOST A TURN"
                    + "\nAND LOST $1000");

                player3.calculateMoney(number);

                int total = player3.getTotalMoney();

                txtPlayerThree.Text = "$" + total.ToString("n2");

                MessageBox.Show("Next players turn");
              
                //hide buttons and messages on the load              
                btnSpinPlayerTwo.Hide();
                btnSolvePlayerTwo.Hide();
                lblMessageTwo.Hide();


                btnSpinPlayerOne.Show();
                btnSolvePlayerOne.Show();
                lblMessageOne.Show();

                btnSpinPlayerThree.Hide();
                btnSolvePlayerThree.Hide();
                lblMessageThree.Hide();

            }//end if 

            else if (p3Spin == 0)
            {
                MessageBox.Show("SORRY BUT YOUR SPIN LANDED ON 0 " + "\nTHIS MEANS YOU LOST A TURN");

                number = 0;

                player3.calculateMoney(number);

                int total = player3.getTotalMoney();

                txtPlayerThree.Text = "$" + total.ToString("n2");

                this.Hide();

                MessageBox.Show("Next players turn");

               // txtPlayerOne.Focus();

                //hide buttons and messages on the load              
                btnSpinPlayerTwo.Hide();
                btnSolvePlayerTwo.Hide();
                lblMessageTwo.Hide();

                btnSpinPlayerOne.Show();
                btnSolvePlayerOne.Show();
                lblMessageOne.Show();

                btnSpinPlayerThree.Hide();
                btnSolvePlayerThree.Hide();
                lblMessageThree.Hide();

            }//end else if

            else
            {
                number = 0;

                player3.calculateMoney(number);

                int total = player3.getTotalMoney();

                txtPlayerThree.Text = "$" + total.ToString("n2");

                MessageBox.Show("Your spin landed on $" + p3Spin + " dollars");

                this.Hide();
                gusser3.Show();

               
            }//end else 
       

        }//end void method validation for the third player
       
    }//end public partial class
}//end namespace
