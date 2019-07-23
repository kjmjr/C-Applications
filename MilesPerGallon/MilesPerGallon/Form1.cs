using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesPerGallon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {

                //declare vars
                double miles = 0;
                double gallons = 0;
                double mpg = 0;



                //get inputs - miles and gallons
                miles = double.Parse(txtMiles.Text);
                gallons = double.Parse(txtGallons.Text);

                //calculate
                mpg = miles / gallons;

                //display answer
                txtMpg.Text = mpg.ToString("n2");

            }//end try statement

            catch
            {
                MessageBox.Show("INVLAID DATA WAS ENTERED. PLEASE ENTER AGAIN.");

                //sets the text box back to blank after the message
                txtMiles.Text = "";
                txtGallons.Text = "";

                //we are lazy so the program puts the cursor back into focus after the message
                txtMiles.Focus();
                

            }//end of catch statement

        }//end of Calculate_Click

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }//end main
}//end namespace
