using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherLibrary;

namespace WeatherTester
{
    public partial class WeatherFormOne : Form
    {
        public WeatherFormOne()
        {
            InitializeComponent();
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            clearInput();
        }//end reset button

        public void btnNext_Click(object sender, EventArgs e)
        {
            WeatherFormTwo wf2 = new WeatherFormTwo();
            WeatherFormOne wf1 = new WeatherFormOne();

            wf1.Hide();
            wf2.Show();

        }//end next page button



        public void btnFahrenheitToCelsius_Click(object sender, EventArgs e)
        {
          
            double F = Double.Parse(txtFahrenheitToCelsius.Text);
            WeatherCalculations wc = new WeatherCalculations();

            txtCelsiusOutput.Text = wc.FahrenheitToCelsius(F).ToString("N2");

           

           
        }//end method

        public void btnFahrenheitToKelvin_Click(object sender, EventArgs e)
        {
           // WeatherCalculations WC = new WeatherCalculations();
        }//end method

        public void btnCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
           // WeatherCalculations WC = new WeatherCalculations();

        }//end method

        public void btnCelsiusToKelvin_Click(object sender, EventArgs e)
        {
           // WeatherCalculations WC = new WeatherCalculations();
        }//end method

        public void btnHeatIndex_Click(object sender, EventArgs e)
        {
           // WeatherCalculations WC = new WeatherCalculations();

        }//end method

        public void btnWindChill_Click(object sender, EventArgs e)
        {
           // WeatherCalculations WC = new WeatherCalculations();
        }//end method

        public void clearInput()
        {

            WeatherFormOne wf1 = new WeatherFormOne();

            wf1.txtCelsiusOutput.Text = "";
            wf1.txtCelsiusToFahrenheit.Text = "";
            wf1.txtCelsiusToKelvin.Text = "";
            wf1.txtFaherheitWindChill.Text = "";
            wf1.txtFahrenheitOutput.Text = "";
            wf1.txtFahrenheitToCelsius.Text = "";
            wf1.txtFahrenheitToKelvin.Text = "";
            wf1.txtHeatIndex.Text = "";
            wf1.txtKelvinOutput.Text = "";
            wf1.txtWindChillOutput.Text = "";
            wf1.txtWindSpeed.Text = "";
            wf1.txtCelsiusToKelvinOutput.Text = "";

        }//end void method 

     
    }//end class

    
}//end namespace
