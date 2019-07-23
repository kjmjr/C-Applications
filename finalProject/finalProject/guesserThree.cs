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
    public partial class guesserThree : Form
    {
        public guesserThree()
        {
            InitializeComponent();
        }

        private void btnGuessThree_Click(object sender, EventArgs e)
        {

            try
            {

                playerThreeMethod();



            }//end try

            catch (FormatException formatE)
            {
                MessageBox.Show(formatE.Message);

            }//end catch

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }//end catch




        }//end btnGuess three button

        private void btnClearThree_Click(object sender, EventArgs e)
        {
            txtGuessThree.Text = " ";
        }//end btnClear three button

        private void btnExitThree_Click(object sender, EventArgs e)
        {

            wheelOfFortune goBack = new wheelOfFortune();

            this.Hide();
            goBack.Show();

        }//end btnExit three button


        public void playerThreeMethod()
        {

            int p3Number = 0;
            int total = 0;
           

            //object used to go back to the main when program goes to default in the switch
            wheelOfFortune p3Main_Screen = new wheelOfFortune();
            wheel playerThree = new wheel();

            //converting the input to a char
            char p3LetterValue = char.Parse(txtGuessThree.Text);

            while (playerThree.getSelectedLetter(p3LetterValue))
            {
                if (playerThree.getSelectedLetter(p3LetterValue))
                {

                    if (p3LetterValue == 'S')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                          + " matches " + "\nSpin to guess another one!");

                        p3Main_Screen.txtS.Text = "S";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();



                    }

                    else if (p3LetterValue == 'O')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                         + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtO.Text = "O";
                        p3Main_Screen.txt2ndO.Text = "O";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        total = playerThree.calculateMoney(p3Number) * 2;

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();


                    }

                    else if (p3LetterValue == 'F')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtF.Text = "F";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if

                    else if (p3LetterValue == 'T')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtT.Text = "T";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if
                    else if (p3LetterValue == 'W')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtW.Text = "W";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if
                    else if (p3LetterValue == 'A')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtA.Text = "A";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if
                    else if (p3LetterValue == 'R')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtR.Text = "R";
                        p3Main_Screen.txt2ndR.Text = "R";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        total = playerThree.calculateMoney(p3Number) * 2;

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if
                    else if (p3LetterValue == 'E')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtE.Text = "E";
                        p3Main_Screen.txt2ndE.Text = "E";
                        p3Main_Screen.txt3rdE.Text = "E";
                        p3Main_Screen.txt4rthE.Text = "E";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        total = playerThree.calculateMoney(p3Number) * 4;

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if
                    else if (p3LetterValue == 'D')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtD.Text = "D";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();

                    }//end else if
                    else if (p3LetterValue == 'V')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtV.Text = "V";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if
                    else if (p3LetterValue == 'L')
                    {
                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtL.Text = "L";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();



                    }//end else if
                    else if (p3LetterValue == 'P')
                    {

                        MessageBox.Show("The letter " + p3LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p3Main_Screen.txtP.Text = "P";
                        p3Main_Screen.lstAvailableLetters.Items.Remove(p3LetterValue);


                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.Show();




                    }//end else if

                    else if (!playerThree.getSelectedLetter(p3LetterValue))
                    {

                        MessageBox.Show("Sorry incorrect letter " + "\nNext players turn");

                        this.Hide();

                        playerThree.calculateMoney(p3Number);

                        total = playerThree.getTotalMoney();

                        p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                        p3Main_Screen.Enabled = true;

                        p3Main_Screen.btnSpinPlayerOne.Show();
                        p3Main_Screen.btnSolvePlayerOne.Show();
                        p3Main_Screen.lblMessageOne.Show();

                        p3Main_Screen.btnSpinPlayerTwo.Show();
                        p3Main_Screen.btnSolvePlayerTwo.Show();
                        p3Main_Screen.lblMessageTwo.Show();

                        p3Main_Screen.btnSpinPlayerThree.Hide();
                        p3Main_Screen.btnSolvePlayerThree.Hide();
                        p3Main_Screen.lblMessageThree.Hide();

                        p3Main_Screen.Show();

                        break;
                    }//end else
                    else
                    {
                        MessageBox.Show("PLEASE TYPE IN A VALID LETTER");

                    }//end else

                }//end if

                //bumps into this if the statement is not true
                else if (!playerThree.getSelectedLetter(p3LetterValue))
                {

                    MessageBox.Show("Sorry incorrect letter " + "\nNext players turn");

                    this.Hide();

                    playerThree.calculateMoney(p3Number);

                    total = playerThree.getTotalMoney();

                    p3Main_Screen.txtPlayerThree.Text = "$" + total.ToString("n2");

                    p3Main_Screen.Enabled = true;

                    p3Main_Screen.btnSpinPlayerOne.Show();
                    p3Main_Screen.btnSolvePlayerOne.Show();
                    p3Main_Screen.lblMessageOne.Show();

                    p3Main_Screen.btnSpinPlayerTwo.Show();
                    p3Main_Screen.btnSolvePlayerTwo.Show();
                    p3Main_Screen.lblMessageTwo.Show();

                    p3Main_Screen.btnSpinPlayerThree.Hide();
                    p3Main_Screen.btnSolvePlayerThree.Hide();
                    p3Main_Screen.lblMessageThree.Hide();


                    p3Main_Screen.Show();

                }//end else if
                else
                {

                    MessageBox.Show("PLEASE TYPE IN A VALID LETTER");

                }//end else

                break;

            }//end while

            if (p3Main_Screen.txtS.Enabled
               && p3Main_Screen.txtO.Enabled
               && p3Main_Screen.txt2ndO.Enabled
               && p3Main_Screen.txtF.Enabled
               && p3Main_Screen.txtT.Enabled
               && p3Main_Screen.txtW.Enabled
               && p3Main_Screen.txtA.Enabled
               && p3Main_Screen.txtR.Enabled
               && p3Main_Screen.txt2ndR.Enabled
               && p3Main_Screen.txtE.Enabled
               && p3Main_Screen.txt2ndE.Enabled
               && p3Main_Screen.txt3rdE.Enabled
               && p3Main_Screen.txt4rthE.Enabled
               && p3Main_Screen.txtD.Enabled
               && p3Main_Screen.txtV.Enabled
               && p3Main_Screen.txtL.Enabled
               && p3Main_Screen.txtP.Enabled)
            {
                winner p3Winner = new winner();

                MessageBox.Show("GOOD JOB");

                //string message
                p3Winner.txtWinner.Text = "Player Three";

                total = playerThree.getTotalMoney();

                p3Winner.txtTotalAmount.Text = "$" + total.ToString("n2");

                p3Winner.Show();


            }//end if

        }//end void method 

        public string answer()
        {

            return "SOFTWARE DEVELOPER";
        }//end public string

    }//end class
}//end namespace
