using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_unformat
{
    public partial class telephoneUnformatForm : Form
    {
        public telephoneUnformatForm()
        {
            InitializeComponent();
        }

        private void telephoneUnformatForm_Load(object sender, EventArgs e)
        {

        }

       

        private void btnUnformat_Click(object sender, EventArgs e)
        {
            string input = txtNumberBox.Text.Trim();

            if (isValidFormat(input))
            {
                unFormat(ref input);
                MessageBox.Show(input);

            }//end if

            else
            {
                MessageBox.Show("Invalid input");

            }//end else


        }//end of btnUnformat void method

        private bool isValidFormat(string str)
        {
            const int VALID_LENGTH = 13;
            bool valid = true;

            if (str.Length == VALID_LENGTH 
                && str[0] == '('
                && str[4] == ')'
                && str[8] == '-')
            {
                valid = true;

            }//end if

            else
            {

                valid = false;
            }//end else

            return valid;

        }//end of isValidFormat bool method

        private void unFormat(ref string str)
        {
            str = str.Remove(0, 1);

            str = str.Remove(3, 1);

            str = str.Remove(6, 1);


        }//end of unFormat void method

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberBox.Text = "";
        }//end of btnClear void method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of btnExit void method

    }//end of class
}//end of namespace
