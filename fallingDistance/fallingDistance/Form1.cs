using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//notes:
//d = 1/2 * gt^2
//d = distance in meters
//g = 9.8
//t is user input

//create a method that accepts the argument of time that user inputs and converts 
//it to meters when returning it 

namespace fallingDistance
{
    public partial class frmFallingDistance : Form
    {
        public frmFallingDistance()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double time = double.Parse(txtTime.Text);

            double meters = FallingDistance(time);

            //prints the results in the text box
            txtResults.Text = meters.ToString("n2");

        }//end btnCalc method

        //our method that returns a double
        private double FallingDistance(double time)
        {
            //d = 1/2 * gt^2
            //d = distance in meters
            //g = 9.8
            //t is user input
    
            //variable for gravity
            double g = 9.8;

            double result = Math.Pow(time, 2.0);

            double d = 1.0 / 2.0 * g * result;

            return d;

        }//end of Falling Distance method that returns the distance

    }//end class
}//end namespace
