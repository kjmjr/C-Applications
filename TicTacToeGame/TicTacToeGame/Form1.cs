using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//when user clicks the new game button it will run through a two dimensional 
//array and show who won
namespace TicTacToeGame
{
    public partial class ticTacToeForm : Form
    {
        Boolean turn = true;
        int turn_counter = 0;
        
        public ticTacToeForm()
        {
            InitializeComponent();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end exit method

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
            turn = true;
            turn_counter = 0;

            foreach (Control c in Controls)
            {

                try
                {
                    Button btn = (Button)c;

                    btn.Enabled = true;
                    btn.Text = "";
                    btnNewGame.Text = "New Game";
                    btnExit.Text = "Exit";

                }//end try
                catch
                {
                    //don't need to catch anything
                }//end catch


            }//end of foreach loop


        }//end of btnNewGame method

        private void btn_click_show(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (turn)
            {
                btn.Text = "X";

            }//end if

            else
            {

                btn.Text = "O";
            }//end else

            turn = !turn;
            btn.Enabled = false;

            turn_counter++;

            determineWinner();


        }//end of btn_click_show void method

        private void determineWinner()
        {

            Boolean we_have_a_winner = false;

            if ((A1.Text == A2.Text ) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                we_have_a_winner = true;
            }//end if
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                we_have_a_winner = true;
            }//end if
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                we_have_a_winner = true;
            }//end if and horizontal match



            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                we_have_a_winner = true;
            }//end if
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                we_have_a_winner = true;
            }//end if
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                we_have_a_winner = true;
            }//end if and vertical match



            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                we_have_a_winner = true;
            }//end if       
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                we_have_a_winner = true;
            }//end if and diagnol match, which is only two outcomes


            if (we_have_a_winner)
            {
                disable_Buttons();

                String winner = "";
                if (turn)
                {
                    winner = "O";
                    txtResult.Text = "Player Y Wins!";

                }//end if
                else
                {
                    winner = "X";
                    txtResult.Text = "Player " + winner + " Wins!";

                }//end else

            }//end if
            else
            {
                if (turn_counter == 9)
                {

                    txtResult.Text = "Tie Game!";
                }//end if

            }//end else


           
        }//end of determineWinner void method

        private void disable_Buttons()
        {
           
            foreach(Control c in Controls){

                try
                {
                    Button btn = (Button)c;

                    btn.Enabled = true;

                }//end try
                catch 
                {
                    //don't need to catch anything
                }//end catch
               
                
            }//end of foreach loop

        }//end of disable_Button Method
    }//end class
}//end namespace
