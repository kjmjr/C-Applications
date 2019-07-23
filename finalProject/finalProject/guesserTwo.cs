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
    public partial class guesserTwo : Form
    {
        public guesserTwo()
        {
            InitializeComponent();
        }

        private void btnGuessTwo_Click(object sender, EventArgs e)
        {


            try
            {

                playerTwoMethod();



            }//end try

            catch (FormatException formatE)
            {
                MessageBox.Show(formatE.Message);

            }//end catch

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }//end catch

        }//end btnGuess Two button

        private void btnClearTwo_Click(object sender, EventArgs e)
        {

            txtGuessTwo.Text = " ";

        }//end btn Clear Two button 

        private void btnExitTwo_Click(object sender, EventArgs e)
        {

            wheelOfFortune goBack = new wheelOfFortune();

            this.Hide();
            goBack.Show();

        }//end btnExit Two button

        public void playerTwoMethod()
        {


            int p2Number = 0;
            int total = 0;
           

            //object used to go back to the main when program goes to default in the switch
            wheelOfFortune p2Main_Screen = new wheelOfFortune();
            wheel playerTwo = new wheel();

            //converting the input to a char
            char p2LetterValue = char.Parse(txtGuessTwo.Text);

            while (playerTwo.getSelectedLetter(p2LetterValue))
            {
                if (playerTwo.getSelectedLetter(p2LetterValue))
                {

                    if (p2LetterValue == 'S')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                          + " matches " + "\nSpin to guess another one!");

                        p2Main_Screen.txtS.Text = "S";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();



                    }

                    else if (p2LetterValue == 'O')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                         + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtO.Text = "O";
                        p2Main_Screen.txt2ndO.Text = "O";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        total = playerTwo.calculateMoney(p2Number) * 2;

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();


                    }

                    else if (p2LetterValue == 'F')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtF.Text = "F";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if

                    else if (p2LetterValue == 'T')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtT.Text = "T";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if
                    else if (p2LetterValue == 'W')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtW.Text = "W";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if
                    else if (p2LetterValue == 'A')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtA.Text = "A";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if
                    else if (p2LetterValue == 'R')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtR.Text = "R";
                        p2Main_Screen.txt2ndR.Text = "R";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        total = playerTwo.calculateMoney(p2Number) * 2;

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if
                    else if (p2LetterValue == 'E')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtE.Text = "E";
                        p2Main_Screen.txt2ndE.Text = "E";
                        p2Main_Screen.txt3rdE.Text = "E";
                        p2Main_Screen.txt4rthE.Text = "E";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        total = playerTwo.calculateMoney(p2Number) * 4;

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if
                    else if (p2LetterValue == 'D')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtD.Text = "D";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();

                    }//end else if
                    else if (p2LetterValue == 'V')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtV.Text = "V";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if
                    else if (p2LetterValue == 'L')
                    {
                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtL.Text = "L";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();



                    }//end else if
                    else if (p2LetterValue == 'P')
                    {

                        MessageBox.Show("The letter " + p2LetterValue
                        + " matches " + "\nSpin to guess another one!");


                        p2Main_Screen.txtP.Text = "P";
                        p2Main_Screen.lstAvailableLetters.Items.Remove(p2LetterValue);


                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.Show();




                    }//end else if

                    else if (!playerTwo.getSelectedLetter(p2LetterValue))
                    {

                        MessageBox.Show("Sorry incorrect letter " + "\nNext players turn");

                        this.Hide();

                        playerTwo.calculateMoney(p2Number);

                        total = playerTwo.getTotalMoney();

                        p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                        p2Main_Screen.Enabled = true;

                        p2Main_Screen.btnSpinPlayerOne.Hide();
                        p2Main_Screen.btnSolvePlayerOne.Hide();
                        p2Main_Screen.lblMessageOne.Hide();

                        p2Main_Screen.btnSpinPlayerTwo.Hide();
                        p2Main_Screen.btnSolvePlayerTwo.Hide();
                        p2Main_Screen.lblMessageTwo.Hide();

                        p2Main_Screen.btnSpinPlayerThree.Show();
                        p2Main_Screen.btnSolvePlayerThree.Show();
                        p2Main_Screen.lblMessageThree.Show();

                        p2Main_Screen.Show();

                        break;
                    }//end else
                    else
                    {
                        MessageBox.Show("PLEASE TYPE IN A VALID LETTER");

                    }//end else

                }//end if

                //bumps into this if the statement is not true
                else if (!playerTwo.getSelectedLetter(p2LetterValue))
                {

                    MessageBox.Show("Sorry incorrect letter " + "\nNext players turn");

                    this.Hide();

                    playerTwo.calculateMoney(p2Number);

                    total = playerTwo.getTotalMoney();

                    p2Main_Screen.txtPlayerTwo.Text = "$" + total.ToString("n2");

                    p2Main_Screen.Enabled = true;

                    p2Main_Screen.btnSpinPlayerOne.Hide();
                    p2Main_Screen.btnSolvePlayerOne.Hide();
                    p2Main_Screen.lblMessageOne.Hide();

                    p2Main_Screen.btnSpinPlayerTwo.Hide();
                    p2Main_Screen.btnSolvePlayerTwo.Hide();
                    p2Main_Screen.lblMessageTwo.Hide();


                    p2Main_Screen.btnSpinPlayerThree.Show();
                    p2Main_Screen.btnSolvePlayerThree.Show();
                    p2Main_Screen.lblMessageThree.Show();

                    p2Main_Screen.Show();

                }//end else if
                else
                {

                    MessageBox.Show("PLEASE TYPE IN A VALID LETTER");

                }//end else

                break;

            }//end while

            if (p2Main_Screen.txtS.Enabled
                && p2Main_Screen.txtO.Enabled
                && p2Main_Screen.txt2ndO.Enabled
                && p2Main_Screen.txtF.Enabled
                && p2Main_Screen.txtT.Enabled
                && p2Main_Screen.txtW.Enabled
                && p2Main_Screen.txtA.Enabled
                && p2Main_Screen.txtR.Enabled
                && p2Main_Screen.txt2ndR.Enabled
                && p2Main_Screen.txtE.Enabled
                && p2Main_Screen.txt2ndE.Enabled
                && p2Main_Screen.txt3rdE.Enabled
                && p2Main_Screen.txt4rthE.Enabled
                && p2Main_Screen.txtD.Enabled
                && p2Main_Screen.txtV.Enabled
                && p2Main_Screen.txtL.Enabled
                && p2Main_Screen.txtP.Enabled)
            {
                winner p2Winner = new winner();

                MessageBox.Show("GOOD JOB");
            
                //string message
                p2Winner.txtWinner.Text = "Player Two";

                total = playerTwo.getTotalMoney();

                p2Winner.txtTotalAmount.Text = "$" + total.ToString("n2");

                p2Winner.Show();


            }//end if



        }//end void method 

        public string answer()
        {

            return "SOFTWARE DEVELOPER";
        }//end public string


    }//end class
}//end namespace
