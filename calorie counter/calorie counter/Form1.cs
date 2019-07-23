using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorie_counter
{
    public partial class calorieCounter : Form
    {

        //declaring variables
        const int banannaCalories = 115;
        const int appleCalories = 80;
        const int orangeCalories = 90;
        const int pearCalories = 120;

        //initialized the total variable with 0
        //in a private 
        private int total = 0;

        public calorieCounter()
        {
            InitializeComponent();
        }


        private void banannaPicture_Click(object sender, EventArgs e)
        {

            total += banannaCalories;

            txtTotalBox.Text = total.ToString("n2");

        }

        private void applePicture_Click(object sender, EventArgs e)
        {

            total += appleCalories;

            txtTotalBox.Text = total.ToString("n2");
        }

        private void orangePicture_Click(object sender, EventArgs e)
        {


            total += orangeCalories;

            txtTotalBox.Text = total.ToString("n2");
        }

        private void pearPicture_Click(object sender, EventArgs e)
        {

            total += pearCalories;

            txtTotalBox.Text = total.ToString("n2");

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTotalBox.Text = "";
            txtTotalBox.Focus();

            
        }

       
    }//end of class
}//end of namespace
