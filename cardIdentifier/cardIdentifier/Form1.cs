using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardIdentifier
{
    public partial class cardID : Form
    {
        public cardID()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void diamondsPictureBox_Click(object sender, EventArgs e)
        {

            valueMessage.Text = "Five of Diamonds!";
        }

        private void heartsPictureBox_Click(object sender, EventArgs e)
        {

            valueMessage.Text = "Six of Hearts!";
        }

        private void spadesPictureBox_Click(object sender, EventArgs e)
        {

            valueMessage.Text = "Ten of Spades!";
        }

        private void jokerPictureBox_Click(object sender, EventArgs e)
        {

            valueMessage.Text = "Joker Black!";
        }

        private void clubsPictureBox_Click_1(object sender, EventArgs e)
        {

            valueMessage.Text = "Three of Clubs!";
        }
    }
}
