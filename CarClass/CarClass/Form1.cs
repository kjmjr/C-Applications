using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*** Add this to your project: have a button on your form that 
//will call a second form with the year and make of your car. ***
namespace CarClass
{
    public partial class carProgramForm : Form
    {
        public carProgramForm()
        {
            InitializeComponent();
        }

        private void carProgramForm_Load(object sender, EventArgs e)
        {

        }//end private void carProgramForm load method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //create the object for the car 
            car CarObject = new car();

            //create the object for the second page
            Information secondPage = new Information();

            secondPage.txtCarYear.Text = CarObject.getYear();
            secondPage.txtCarMake.Text = CarObject.getMake();
            secondPage.Show();



        }//end of btnView void method 

        private void btnBrake_Click(object sender, EventArgs e)
        {
            car CarObject = new car();

          
            double carBrakeSpeed = CarObject.brake(Convert.ToDouble(txtSpeedBox.Text));

      
            if (carBrakeSpeed < 0)
            {
                MessageBox.Show("Number typed is to low");

            }//end if

            else
            {
                txtNewSpeed.Text = carBrakeSpeed.ToString();

            }//end else 

           

        }//end of brake void method 

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            car CarObject = new car();

            double carAccelerateSpeed = CarObject.accelerate(Convert.ToDouble(txtSpeedBox.Text));
     
            txtNewSpeed.Text = carAccelerateSpeed.ToString();
        }//end of accelerate void method

    }//end class
}//end namespace
