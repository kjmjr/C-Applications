using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    /*
     * 1.Temperature conversions – 
     * Fahrenheit to Celsius, Fahrenheit to Kelvin, 
     * Celsius to Fahrenheit, Celsius to Kelvin
        2.	Heat Index
        3.	Wind Chill
        4.	Dew Point
        5.	Virtual Temperature
        6.	Humidity
        8.	Volume of Rainfall
        9.	Mixing Ratio
        10.	Wind Speed – MPH to Knots, Knots to MPH   
     */
    public class WeatherCalculations
    {
        public double FahrenheitToCelsius(double F)
        {

            return (F - 32.0) * 5.0 / 9.0;
        }//end method

        public double FahrenheitToKelvin(double F)
        {
            return (F - 32) * 5.0 / 9.0 + 273.15;

        }//end method
    
        public double CelsiusToFahrenheit(double C)
        {
            return (C * 9.0 / 5.0) + 32.0;

        }//end method

        public double CelsiusToKelvin(double C)
        {

            return C + 273.15;
        }//end method

        //to find the heat index, it is the temperature times the relative energy
        public double HeatIndex(double F)
        {
            return F * 0.7;

        }//end method

        public double WindChill(double F, double windSpeed)
        {
            return 35.74 + (0.6215 * F) - ( 35.75 * Math.Pow(windSpeed, 0.16) + (0.4275 * F * Math.Pow(windSpeed,0.16)));

        }//end method

        public double DewPoint(double F)
        {
            return (Math.Pow(0.7 / 100.0, 1.0 / 8.0)) * (112.0 + (0.9 * F)) - 112.0;

        }//end method

        public double VirtualTemperature(double vaporPressure, double stationPressure, double temperatureC)
        {

            return ((temperatureC + 273.16) / (1.0 - 0.378 * (vaporPressure / stationPressure))) - 273.16;

        }//end method

        public double Humidity(double saturationVaporPreasure, double vaporPreasure)
        {
            //mb - saturation vapor preasure
            //E - vapor preasure
            //SH= (0.622*E)/(Mb-(0.378*E))
            return (0.622 * vaporPreasure) / (saturationVaporPreasure - (0.378 * vaporPreasure));

        }//end method

    

        public double VolumeOfRainfall(double height, double contachementArea)
        {

            //Water Volume (V) = Water Catchement Area × Rainfall Height
            return contachementArea * height;

        }//end method

        public double MixingRatio(double Ms)
        {
            //M= RH*Ms/100
            return (0.07 * Ms) / 100.0;

        }//end method

        public double MPHToKnots(double mph)
        {
            return mph * 0.86;

        }//end method

        public double KnotsToMPH(double knots)
        {

            return 1.151 * knots;
        }//end method

        /*
         * 
         * CLEAR BUTTON
         *  WeatherFormOne wf1 = new WeatherFormOne();

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


         WeatherFormTwo wf2 = new WeatherFormTwo();
            WeatherFormOne wf1 = new WeatherFormOne();

            wf1.Hide();
            wf2.Show();

         double F = Double.Parse(txtFahrenheitToCelsius.Text);
            WeatherCalculations wc = new WeatherCalculations();

            txtCelsiusOutput.Text = wc.FahrenheitToCelsius(F).ToString("N2");\

         * 
         * 
         * 
         * 
         */
        //a few tips for parsing and formatting

        //Double.TryParse(txt.Text, out total)
        //Convert.ToDouble(txtChipPrice.Text);
        //string.Format("{0:0.00}", total);
        // decimal Debitvalue = 1156.547m;
        // decimal DEBITAMT = Convert.ToDecimal(string.Format("{0:F2}", Debitvalue));
        //decimal decimalRounded = Decimal.Parse(Debitvalue.ToString("0.00"));
    }//end class
}//end namespace
