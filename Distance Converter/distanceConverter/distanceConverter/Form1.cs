using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Kevin Mcadoo
//Date: 9-6-2018
//Purpose: distance converter with the list box

//prompt user
//on button click use if statements if item is selected and conert inches to feet or other

namespace distanceConverter
{
    public partial class distanceConverter : Form
    {
        public distanceConverter()
        {
            InitializeComponent();
        }

           

        private void btnConvert_Click(object sender, EventArgs e)
        {

            double distance, answer;

            //program will try and parse and once it does it will pass through the selection process
            if (Double.TryParse(txtDistance.Text, out distance))
            {
                if (lstFromBox.SelectedIndex != -1)
                {
                    if (lstToBox.SelectedIndex != -1)
                    {
                        if (lstFromBox.SelectedIndex == 0 && (lstToBox.SelectedIndex == 0))
                        {
                            answer = distance;

                            txtAnswer.Text = answer.ToString("n2");

                        }
                        if (lstFromBox.SelectedIndex == 0 && (lstToBox.SelectedIndex == 1))
                        {
                            answer = distance / 12;

                            txtAnswer.Text = answer.ToString("n2");

                        }

                        if (lstFromBox.SelectedIndex == 0 && (lstToBox.SelectedIndex == 2))
                        {

                            answer = distance / 36;

                            txtAnswer.Text = answer.ToString("n2");
                        }

                        if (lstFromBox.SelectedIndex == 1 && (lstToBox.SelectedIndex == 0))
                        {
                            answer = distance * 12;

                            txtAnswer.Text = answer.ToString("n2");

                        }

                        if (lstFromBox.SelectedIndex == 1 && (lstToBox.SelectedIndex == 1))
                        {
                            answer = distance;

                            txtAnswer.Text = answer.ToString("n2");

                        }

                        if (lstFromBox.SelectedIndex == 1 && (lstToBox.SelectedIndex == 2))
                        {
                            answer = distance / 3;

                            txtAnswer.Text = answer.ToString("n2");
                        }

                        if (lstFromBox.SelectedIndex == 2 && (lstToBox.SelectedIndex == 0))
                        {
                            answer = distance * 36;

                            txtAnswer.Text = answer.ToString("n2");
                        }

                        if (lstFromBox.SelectedIndex == 2 && (lstToBox.SelectedIndex == 1))
                        {
                            answer = distance * 3;

                            txtAnswer.Text = answer.ToString("n2");
                        }

                        if (lstFromBox.SelectedIndex == 2 && (lstToBox.SelectedIndex == 2))
                        {
                            answer = distance;

                            txtAnswer.Text = answer.ToString("n2");

                        }


                    }
                    else
                    {
                        MessageBox.Show("PLEASE SELECT AN ITEM FROM THE TO BOX");

                    }

                }
                else
                {
                    MessageBox.Show("PLEASE SELECT AN ITEM FROM THE FROM BOX");

                }

            }

            else
            {

                MessageBox.Show("PLEASE ENTER A NUMBER");

                //sets the text box back to blank after the message
                txtDistance.Text = "";

                //sets the line back into box after the catch
                txtAnswer.Focus();
            }


        }
           

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }//end of class

  }//end of namespace

   
  
 