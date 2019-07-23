using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//make a method that holds morsecode as an array and excepts a string
namespace morseCodeConverter
{

    struct MorseCode
    {
        public string sentence;

    }

    public partial class morseCodeForm : Form
    {

        private List <MorseCode> MorseCodeList  = new List <MorseCode>();
        public morseCodeForm()
        {
            InitializeComponent();
        }

        private void morseCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create instance
            MorseCode s = new MorseCode();

            //call method to get data from screen
            getSentences(ref s);

            //add to list object
            MorseCodeList.Add(s);

            txtPhrase.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

           // string str;
            //create instance
           // MorseCode l = new MorseCode();

          
            foreach (MorseCode m in MorseCodeList)
            {

                convert();
                //str = "Code: ";
               // lstMorseCode.Items.Add(str);
            }//end foreach
            
        }

        private void getSentences(ref MorseCode phrase)
        {
            try
            {

                phrase.sentence = txtPhrase.Text;

            }//end try

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }//end catch


        }//end of void method

        private void convert()
        {
           
            string [] morseCode = {"--..--", ".-.-.-", "..--..", "-----"
              ,".----","..---","...--", "....-", "....."
            , "-....", "--...", "---..", "----.", ".-"
            , "-...", "-.-.", "-..", ".", "..-."
            , "--.", "....", "..", ".---", "-.-"
            , ".-..", "---", "-.", "---", ".--."
            , "--.-", ".-.", "...", "-", "..-", "...-"
            , ".--", "-..-", "-.--", "--.."};


            string[] characters = {",", ".","?","0", "1", "2", "3"
            ,"4","5","6","7","8","9","A","B","C","D","E","F","G"
            ,"H","I","J","K","L","M","N","O","P","Q","R","S"
            ,"T","U","V","W","X","Y","Z"};

            //39 characters
         
            if (morseCode[0] == characters[0])
            {

                lstMorseCode.Items.Add(morseCode[0]);
            }
            else if (morseCode[1] == characters[1])
            {

                lstMorseCode.Items.Add(morseCode[1]);
            }
            else if (morseCode[2] == characters[2])
            {

                lstMorseCode.Items.Add(morseCode[2]);
            }
            else if (morseCode[3] == characters[3])
            {
                lstMorseCode.Items.Add(morseCode[3]);

            }
            else if (morseCode[4] == characters[4])
            {

                lstMorseCode.Items.Add(morseCode[4]);
            }
            else if (morseCode[5] == characters[5])
            {
                lstMorseCode.Items.Add(morseCode[5]);

            }
            else if (morseCode[6] == characters[6])
            {
                lstMorseCode.Items.Add(morseCode[6]);

            }
            else if (morseCode[7] == characters[7])
            {

                lstMorseCode.Items.Add(morseCode[7]);
            }
            else if (morseCode[8] == characters[8])
            {
                lstMorseCode.Items.Add(morseCode[8]);

            }
            else if (morseCode[9] == characters[9])
            {
                lstMorseCode.Items.Add(morseCode[9]);

            }
            else if (morseCode[10] == characters[10])
            {
                lstMorseCode.Items.Add(morseCode[10]);

            }
            else if (morseCode[11] == characters[11])
            {

                lstMorseCode.Items.Add(morseCode[11]);

            }
            else if (morseCode[12] == characters[12])
            {

                lstMorseCode.Items.Add(morseCode[12]);
            }
            else if (morseCode[13] == characters[13])
            {

                lstMorseCode.Items.Add(morseCode[13]);
            }
            else if (morseCode[14] == characters[14])
            {
                lstMorseCode.Items.Add(morseCode[14]);

            }
            else if (morseCode[15] == characters[15])
            {

                lstMorseCode.Items.Add(morseCode[15]);
            }
            else if (morseCode[16] == characters[16])
            {

                lstMorseCode.Items.Add(morseCode[16]);
            }
            else if (morseCode[17] == characters[17])
            {

                lstMorseCode.Items.Add(morseCode[17]);
            }
            else if (morseCode[18] == characters[18])
            {
                lstMorseCode.Items.Add(morseCode[18]);

            }
            else if (morseCode[19] == characters[19])
            {

                lstMorseCode.Items.Add(morseCode[19]);
            }
            else if (morseCode[20] == characters[20])
            {

                lstMorseCode.Items.Add(morseCode[20]);
            }
            else if (morseCode[21] == characters[21])
            {

                lstMorseCode.Items.Add(morseCode[21]);
            }
            else if (morseCode[22] == characters[22])
            {
                lstMorseCode.Items.Add(morseCode[22]);

            }
            else if (morseCode[23] == characters[23])
            {
                lstMorseCode.Items.Add(morseCode[23]);

            }

            else if (morseCode[24] == characters[24])
            {
                lstMorseCode.Items.Add(morseCode[24]);

            }

            else if (morseCode[25] == characters[25])
            {
                lstMorseCode.Items.Add(morseCode[25]);

            }

            else if (morseCode[26] == characters[26])
            {

                lstMorseCode.Items.Add(morseCode[26]);
            }

            else if (morseCode[27] == characters[27])
            {

                lstMorseCode.Items.Add(morseCode[27]);
            }

            else if (morseCode[28] == characters[28])
            {

                lstMorseCode.Items.Add(morseCode[28]);
            }
            else if (morseCode[29] == characters[29])
            {
                lstMorseCode.Items.Add(morseCode[29]);

            }

            else if (morseCode[30] == characters[30])
            {
                lstMorseCode.Items.Add(morseCode[30]);

            }

            else if (morseCode[31] == characters[31])
            {

                lstMorseCode.Items.Add(morseCode[31]);
            }

            else if (morseCode[32] == characters[32])
            {

                lstMorseCode.Items.Add(morseCode[32]);
            }


            else if (morseCode[33] == characters[33])
            {

                lstMorseCode.Items.Add(morseCode[33]);
            }


            else if (morseCode[34] == characters[34])
            {
                lstMorseCode.Items.Add(morseCode[34]);

            }

            else if (morseCode[35] == characters[35])
            {

                lstMorseCode.Items.Add(morseCode[35]);
            }


            else if (morseCode[36] == characters[36])
            {

                lstMorseCode.Items.Add(morseCode[36]);
            }


            else if (morseCode[37] == characters[37])
            {
                lstMorseCode.Items.Add(morseCode[37]);

            }

            else if (morseCode[38] == characters[38])
            {

                lstMorseCode.Items.Add(morseCode[38]);
            }


            else if (morseCode[39] == characters[39])
            {

                lstMorseCode.Items.Add(morseCode[39]);
            }






            // return morseCode;

        }//end string convert method 



    }//end class
}//end namespace
