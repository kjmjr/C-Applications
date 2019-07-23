using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//make a label 
//take the first letter of each word and append it to the back of each word
//append the string ay to every word that is entered into the text box
//make a add button and clear the items in the text box
//make a display button that adds the items into a list
// In addition, your program should also display the number of words in the original sentence**
// Also, your program should count the number of vowels(a, e, i, o, u) in the original sentence**



namespace pigLatin

{
    public partial class pigLatinForm : Form
    {

        const string EXTENDEDLETTERS = "ay";

        public pigLatinForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }//end void

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            char [] vowels = {'a', 'e', 'i', 'o', 'u' };
          
            int letterCounter = 0;
            int vowelCounter = 0;

          
            string input = txtInput.Text;

          
            for (int i = 0; i <= input.Length; i++)
            {

                letterCounter = +i;

            }//end for

            for (int v = 0; v < input.Length; v++)
            {
                if (vowels.Contains(input[v]))
                {
                    vowelCounter++;

                }//end if

            }//end for

            txtTotal.Text = "Total amount of letters is " + letterCounter;
            txtVowels.Text = "Amount of vowels is " + vowelCounter;

            string translate = "";
            string[] translateInput = input.Split(' ');


            for (int s = 0; s < translateInput.Length; s++)
            {
                translate += getPigLatinWord(translateInput[s]);


            }//end for

            txtOutput.Text = translate;

          

        }//end void btnDisplay method

        private string getPigLatinWord(string input)
        {
            string word;
            string firstLetter = input.Substring(0, 1);

            word = input.Substring(1) + firstLetter + EXTENDEDLETTERS + " ";


            return word;
        }//end of string translateWord method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }//end of btnExit method

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = " ";
            txtTotal.Text = "";
            txtInput.Text = "";
            txtVowels.Text = "";

        }//end of btnClear method

    }//end class
}//end namespace
