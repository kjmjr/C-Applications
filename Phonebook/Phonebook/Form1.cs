using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{

    struct PhoneBookEntry
    {
        public string name;
        public string phone;

    }//end struct

    public partial class phoneBookForm : Form
    {
        private List<PhoneBookEntry> PhoneList = new List<PhoneBookEntry>();

        public phoneBookForm()
        {
            InitializeComponent();
        }

        private void phoneBookForm_Load(object sender, EventArgs e)
        {
            ReadFile();

            DisplayNames();
        }

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;
                string line;

                PhoneBookEntry entry = new PhoneBookEntry();

                char[] delim = { ',' };

                inputFile = File.OpenText("PhoneList.txt");

                while (!inputFile.EndOfStream)
                {

                    line = inputFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    PhoneList.Add(entry);


                }//end while


            }//end try
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }//end catch

        }//end void readFile method

        private void DisplayNames()
        {
            foreach(PhoneBookEntry entry in PhoneList)
            {
                nameListBox.Items.Add(entry.name);

            }//end foreach

        }//end of void DisplayNames method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;

            phoneLabel.Text = PhoneList[index].phone;
        }
    }//end class
}//end namespace
