using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordValidator
{
    public partial class passwordValidationForm : Form
    {
        public passwordValidationForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }//end void form load method

        private int NumberUpperCase(String str)
        {
            int uppercase = 0;

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    uppercase++;

                }//end if
              

            }//end foreach

           
            return uppercase;
        }//end int NumberUpperCase method

        private int NumberLowerCase(String str)
        {
            int lowerCase = 0;

            foreach(char ch in str)
            {

                if (char.IsLower(ch))
                {
                    lowerCase++;

                }//end if

            }//end foreach

            return lowerCase;

        }//end NumberLowerCase method

        private int NumberDigits(String str)
        {

            int digits = 0;

            foreach(char ch in str)
            {

                if (char.IsDigit(ch))
                {

                    digits++;

                }//end if

            }//end foreach

            return digits;


        }//end NUmberDigits method


        private void btnCheck_Click(object sender, EventArgs e)
        {

            const int MIN_LENGTH = 8;

            string password = txtPassword.Text;

            if (password.Length >= MIN_LENGTH && 
                NumberUpperCase(password) >= 1
                && NumberLowerCase(password) >= 1
                && NumberDigits(password) >= 1)
            {

                MessageBox.Show("The password is valid.");

            }//end if

            else
            {

                MessageBox.Show("The password does not meet " + "the requirments. ");

            }//end else

        }//end btnCheck void method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnExit void method
    }//end class
}//end namespace
