using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Spectrum
{

    enum Spectrum
    {
        Red, Orange, Yellow, Green, Blue, Indigo, Violet

    }//end enum
    public partial class colorSpectrumForm : Form
    {
        public colorSpectrumForm()
        {
            InitializeComponent();
        }

        private void colorSpectrumForm_Load(object sender, EventArgs e)
        {

        }//end void method

        private void DisplayColor(Spectrum color)
        {
            txtColorBox.Text = color.ToString();

        }//end void DisplayColor method

        private void lblRed_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        private void lblOrange_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        private void lblYellow_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        private void lblGreen_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        private void lblBlue_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        private void lblIndigo_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Indigo);
        }

        private void lblViolet_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Violet);
        }
    }//end class
}//end namespace
