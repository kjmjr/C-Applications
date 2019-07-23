using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{

    struct Automobile
    {

        public string make;
        public int year;
        public double mileage;
    }//end struct

    public partial class carListForm : Form
    {

        private List<Automobile> carList = new List<Automobile>();

        public carListForm()
        {
            InitializeComponent();
        }

        private void carListForm_Load(object sender, EventArgs e)
        {

        }

        private void GetData(ref Automobile auto)
        {
            try
            {

                auto.make = txtMake.Text;
                auto.year = int.Parse(txtYear.Text);
                auto.mileage = double.Parse(txtMileage.Text);

            }//end try
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }//end catch

        }//end of void GetData method

        private void btnAddCar_Click(object sender, EventArgs e)
        {

            Automobile car = new Automobile();

            GetData(ref car);

            carList.Add(car);

            //clear the boxes
            txtMake.Clear();
            txtYear.Clear();
            txtMileage.Clear();

            //focus the cursor
            txtMake.Focus();



        }//end of btnAddCar void method

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            string output;

            lstCarListBox.Items.Clear();

            foreach (Automobile aCar in carList)
            {
                output = aCar.year + " " + aCar.make + " with " + aCar.mileage + " miles.";

                lstCarListBox.Items.Add(output);

            }//end foreach

        }//end of btnDisplay void method
    }//end of class
}//end of namespace
