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
    public partial class solver : Form
    {
        public solver()
        {
            InitializeComponent();
        }
        //variable can be used throughout entire program
          public static int num = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            wheelOfFortune goBack = new wheelOfFortune();

            this.Hide();
            goBack.Show();

        }//end void method

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtSolve.Text = " ";

        }//end void method 

        private void btnSolve_Click(object sender, EventArgs e)
        {
               
            try
            {
                wheelOfFortune finish = new wheelOfFortune();
                wheel player1Money = new wheel();
                wheel player2Money = new wheel();
                wheel player3Money = new wheel();

                //make 3 guessers have a answer method in there class to use here
                guesser g1 = new guesser();
                guesserTwo g2 = new guesserTwo();
                guesserThree g3 = new guesserThree();

                //if and else statements for player 1
                if (g1.answer() == "SOFTWARE DEVELOPER" && 
                    txtSolve.Text == "SOFTWARE DEVELOPER")
                {
             
                    txtSolve.Text = "SOFTWARE DEVELOPER";

                    int total = player1Money.getTotalMoney();

                    MessageBox.Show("Congratulations player one has won the game!" + "\nAmount of money won: "
                        + total.ToString("n2"));

                   //calling a void method 
                    gameOver();



                }//end if

                else
                {
                    MessageBox.Show("OOPS that is not the right answer....Next players turn");

                    this.Hide();
                    finish.Show();
                 

                    //hide buttons and messages
                    finish.btnSpinPlayerOne.Hide();
                    finish.btnSolvePlayerOne.Hide();
                    finish.lblMessageOne.Hide();

                    finish.btnSpinPlayerTwo.Show();
                    finish.btnSolvePlayerTwo.Show();
                    finish.lblMessageTwo.Show();


                    finish.btnSpinPlayerThree.Hide();
                    finish.btnSolvePlayerThree.Hide();
                    finish.lblMessageThree.Hide();


                }//end else



                //if and else statements for player 2
                if (g2.answer() == "SOFTWARE DEVELOPER" && 
                    txtSolve.Text == "SOFTWARE DEVELOPER")
                {

                    txtSolve.Text = "SOFTWARE DEVELOPER";

                    int total = player2Money.getTotalMoney();

                    MessageBox.Show("Congratulations player two has won the game!" + "\nAmount of money won: "
                        + total.ToString("n2"));

                    //calling a void method 
                    gameOver();



                }//end if

                else
                {
                    MessageBox.Show("OOPS that is not the right answer....Next players turn");

                    this.Hide();
                    finish.Show();

                   
                    //hide buttons and messages
                    finish.btnSpinPlayerOne.Hide();
                    finish.btnSolvePlayerOne.Hide();
                    finish.lblMessageOne.Hide();

                    finish.btnSpinPlayerTwo.Hide();
                    finish.btnSolvePlayerTwo.Hide();
                    finish.lblMessageTwo.Hide();

                    finish.btnSpinPlayerThree.Show();
                    finish.btnSolvePlayerThree.Show();
                    finish.lblMessageThree.Show();


                }//end else



                //if and else statements for player 3
                if (g3.answer() == "SOFTWARE DEVELOPER" && 
                    txtSolve.Text == "SOFTWARE DEVELOPER")
                {

                    txtSolve.Text = "SOFTWARE DEVELOPER";

                    int total = player3Money.getTotalMoney();

                    MessageBox.Show("Congratulations player three has won the game!" + "\nAmount of money won: "
                        + total.ToString("n2"));

                    //calling a void method 
                    gameOver();



                }//end if

                else
                {
                    MessageBox.Show("OOPS that is not the right answer....Next players turn");
                 
                    this.Hide();
                    finish.Show();

                    //hide buttons and messages
                    finish.btnSpinPlayerOne.Show();
                    finish.btnSolvePlayerOne.Show();
                    finish.lblMessageOne.Show();

                    finish.btnSpinPlayerTwo.Hide();
                    finish.btnSolvePlayerTwo.Hide();
                    finish.lblMessageTwo.Hide();

                    finish.btnSpinPlayerThree.Hide();
                    finish.btnSolvePlayerThree.Hide();
                    finish.lblMessageThree.Hide();


                }//end else


            }//end try

            catch (FormatException formatE)
            {

                MessageBox.Show(formatE.Message);

            }//end catch

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }//end catch
            
            
        }//end void method

        public void gameOver()
        {

            wheelOfFortune finish = new wheelOfFortune();              
            this.Hide();
                   
            //17 letters will be set in the boxes
            finish.txtS.Text = "S";
            finish.txtO.Text = "O";
            finish.txtF.Text = "F";
            finish.txtT.Text = "T";
            finish.txtW.Text = "W";
            finish.txtA.Text = "A";
            finish.txtR.Text = "R";
            finish.txtE.Text = "E";

            finish.txtD.Text = "D";
            finish.txt2ndE.Text = "E";
            finish.txtV.Text = "V";
            finish.txt3rdE.Text = "E";
            finish.txtL.Text = "L";
            finish.txt2ndO.Text = "O";
            finish.txtP.Text = "P";
            finish.txt4rthE.Text = "E";
            finish.txt2ndR.Text = "R";

            //hide buttons and messages when game is over
            finish.btnSpinPlayerOne.Hide();
            finish.btnSolvePlayerOne.Hide();
            finish.lblMessageOne.Hide();

            finish.btnSpinPlayerTwo.Hide();
            finish.btnSolvePlayerTwo.Hide();
            finish.lblMessageTwo.Hide();

            finish.btnSpinPlayerThree.Hide();
            finish.btnSolvePlayerThree.Hide();
            finish.lblMessageThree.Hide();
        
            
            char[] lettersArray = new[] { 'A','B','C','D','E','F','G','H','I','J'
            ,'K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

            //clears all of the items from the avaliable letters of the board 
            finish.lstAvailableLetters.Items.Clear();

            finish.Show();

            MessageBox.Show("Game over thanks for playing!");
          

        }//end void set
       
    }//end class
}//end namespace
