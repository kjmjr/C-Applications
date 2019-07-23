using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telephoneFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isValidNumber(String str)
        {
            const int VALID_LENGTH = 10;
            bool valid = true;

            if(str.Length == VALID_LENGTH)
            {
                foreach (char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;

                    }//end if

                }//end foreach

            }//end if

            else
            {
                valid = false;

            }//end else

            return valid;

        }//end of isValidNumber method

        private void TelephoneFormat(ref string str)
        {

            str = str.Insert(0, "(");

            str = str.Insert(4, ")");

            str = str.Insert(8, "-");

        }//end of void TelephoneFormat method


        private void btnFormat_Click(object sender, EventArgs e)
        {

            string input = txtNumber.Text.Trim();

            if (isValidNumber(input))
            {
                TelephoneFormat(ref input);
                MessageBox.Show(input);

            }//end if

            else
            {

                MessageBox.Show("Invalid input");

            }//end else

        }//end btnForamt method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end void btnExit method

        
    }//end class
}//end namespace
