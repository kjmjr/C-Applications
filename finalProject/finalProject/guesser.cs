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
    public partial class guesser : Form
    {

        public guesser()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            try {

                playerOneMethod();




            }//end try

            catch (FormatException formatE)
            {
                MessageBox.Show(formatE.Message);

            }//end catch

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }//end catch



        }//end void btnGuess button click method


        private void btnExit_Click(object sender, EventArgs e)
        {
            wheelOfFortune goBack = new wheelOfFortune();

            this.Hide();
            goBack.Show();

        }//end void btnExit button method

        //this method clears the text box if button is pressed
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuessOne.Text = " ";

        }//end void btnClear button method

        //start of the method for the first player  
        public void playerOneMethod()
        {

            int p1Number = 0;
            int total = 0;


            //object used to go back to the main when program goes to default in the switch
            wheelOfFortune p1Main_Screen = new wheelOfFortune();
            wheel playerOne = new wheel();

            //converting the input to a char
            char p1LetterValue = char.Parse(txtGuessOne.Text);

            while (playerOne.getSelectedLetter(p1LetterValue))
            {
                if (playerOne.getSelectedLetter(p1LetterValue))
                {

                    if (p1LetterValue == 'S')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                          + " matches " + "\nSpin to guess another one!");

                        p1Main_Screen.txtS.Text = "S";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();



                    }

                    else if (p1LetterValue == 'O')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                         + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtO.Text = "O";
                        p1Main_Screen.txt2ndO.Text = "O";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        total = playerOne.calculateMoney(p1Number) * 2;

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();


                    }

                    else if (p1LetterValue == 'F')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtF.Text = "F";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if

                    else if (p1LetterValue == 'T')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtT.Text = "T";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if
                    else if (p1LetterValue == 'W')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtW.Text = "W";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if
                    else if (p1LetterValue == 'A')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtA.Text = "A";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if
                    else if (p1LetterValue == 'R')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtR.Text = "R";
                        p1Main_Screen.txt2ndR.Text = "R";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        total = playerOne.calculateMoney(p1Number) * 2;

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if
                    else if (p1LetterValue == 'E')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtE.Text = "E";
                        p1Main_Screen.txt2ndE.Text = "E";
                        p1Main_Screen.txt3rdE.Text = "E";
                        p1Main_Screen.txt4rthE.Text = "E";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        total = playerOne.calculateMoney(p1Number) * 4;

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if
                    else if (p1LetterValue == 'D')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtD.Text = "D";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();

                    }//end else if
                    else if (p1LetterValue == 'V')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtV.Text = "V";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if
                    else if (p1LetterValue == 'L')
                    {
                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtL.Text = "L";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();



                    }//end else if
                    else if (p1LetterValue == 'P')
                    {

                        MessageBox.Show("The letter " + p1LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p1Main_Screen.txtP.Text = "P";
                        p1Main_Screen.lstAvailableLetters.Items.Remove(p1LetterValue);


                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.Show();




                    }//end else if

                    else if (!playerOne.getSelectedLetter(p1LetterValue))
                    {

                        MessageBox.Show("Sorry incorrect letter " + "\nNext players turn");

                        this.Hide();

                        playerOne.calculateMoney(p1Number);

                        total = playerOne.getTotalMoney();

                        p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                        p1Main_Screen.Enabled = true;

                        p1Main_Screen.btnSpinPlayerOne.Hide();
                        p1Main_Screen.btnSolvePlayerOne.Hide();
                        p1Main_Screen.lblMessageOne.Hide();

                        p1Main_Screen.btnSpinPlayerTwo.Show();
                        p1Main_Screen.btnSolvePlayerTwo.Show();
                        p1Main_Screen.lblMessageTwo.Show();

                        p1Main_Screen.btnSpinPlayerThree.Hide();
                        p1Main_Screen.btnSolvePlayerThree.Hide();
                        p1Main_Screen.lblMessageThree.Hide();

                        p1Main_Screen.Show();

                        break;
                    }//end else
                    else
                    {
                        MessageBox.Show("PLEASE TYPE IN A VALID LETTER");

                    }//end else

                }//end if

                //bumps into this if the statement is not true
                else if (!playerOne.getSelectedLetter(p1LetterValue))
                {

                    MessageBox.Show("Sorry incorrect letter " + "\nNext players turn");

                    this.Hide();

                    playerOne.calculateMoney(p1Number);

                    total = playerOne.getTotalMoney();

                    p1Main_Screen.txtPlayerOne.Text = "$" + total.ToString("n2");

                    p1Main_Screen.Enabled = true;

                    p1Main_Screen.btnSpinPlayerOne.Hide();
                    p1Main_Screen.btnSolvePlayerOne.Hide();
                    p1Main_Screen.lblMessageOne.Hide();

                    p1Main_Screen.btnSpinPlayerTwo.Show();
                    p1Main_Screen.btnSolvePlayerTwo.Show();
                    p1Main_Screen.lblMessageTwo.Show();

                    p1Main_Screen.btnSpinPlayerThree.Hide();
                    p1Main_Screen.btnSolvePlayerThree.Hide();
                    p1Main_Screen.lblMessageThree.Hide();

                    p1Main_Screen.Show();

                }//end else if
                else
                {

                    MessageBox.Show("PLEASE TYPE IN A VALID LETTER");

                }//end else

                break;

            }//end while

            if (p1Main_Screen.txtS.Enabled 
                && p1Main_Screen.txtO.Enabled
                && p1Main_Screen.txt2ndO.Enabled
                && p1Main_Screen.txtF.Enabled
                && p1Main_Screen.txtT.Enabled
                && p1Main_Screen.txtW.Enabled
                && p1Main_Screen.txtA.Enabled
                && p1Main_Screen.txtR.Enabled
                && p1Main_Screen.txt2ndR.Enabled
                && p1Main_Screen.txtE.Enabled
                && p1Main_Screen.txt2ndE.Enabled
                && p1Main_Screen.txt3rdE.Enabled
                && p1Main_Screen.txt4rthE.Enabled
                && p1Main_Screen.txtD.Enabled
                && p1Main_Screen.txtV.Enabled
                && p1Main_Screen.txtL.Enabled
                && p1Main_Screen.txtP.Enabled)
            {
                winner p1Winner = new winner();

                MessageBox.Show("GOOD JOB");
                
                //string message
                p1Winner.txtWinner.Text = "Player One";

                total = playerOne.getTotalMoney();

                p1Winner.txtTotalAmount.Text = "$" + total.ToString("n2");

                p1Winner.Show();

            }//end if



        }//end void player one method  

        public string answer()
        {

            return "SOFTWARE DEVELOPER";
        }//end public string

              

    }//end class

}//end namespace
