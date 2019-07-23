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

namespace Sales
{
    public partial class totalSales : Form
    {
        public totalSales()
        {
            InitializeComponent();
        }

        private void btnArrayClick_Click(object sender, EventArgs e)
        {
            
          
            try
            {
                //initialize variables
                const int SIZE = 7;
                double[] numbersArray = new double[SIZE]; 
                double largest = 0.0;
                double smallest = 0;
                double average = 0.0;

                //calling methods that passed an array
                ReaderMethod(numbersArray);
                average = AverageValueMethod(numbersArray);
                largest = HighestValueMethod(numbersArray);
                smallest = LowestValueMethod(numbersArray);

                //displaying results
                txtLargest.Text = largest.ToString("n2");
                txtSmallest.Text = smallest.ToString("n2");
                txtAverage.Text = average.ToString("n2");

            }//end try
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }//end catch

        }//end btnArray click method

        //passing the declared array into the method to read from a file
        private void ReaderMethod(double [] numbersArray)
        {

            //initialize variables
            //const int SIZE = 7;
           // double[] numbersArray = new double[SIZE];
            int i = 0;

            //Pass the file path and file name to the StreamReader constructor
            System.IO.StreamReader reader = new StreamReader("sales.txt");
            while (i < numbersArray.Length)
            {
                numbersArray[i] = double.Parse(reader.ReadLine());
                i++;

            }//end while
             //close the file
            reader.Close();
            // Console.ReadLine();

            foreach (double number in numbersArray)
            {
                lstArray.Items.Add(number);

            }//end of foreach method

        }//end of ReaderMethod

        private double AverageValueMethod(double [] numbersArray)
        {
            //declaring variables
            double total = 0.0;
            double average = 0.0;
           

            for (int i = 0; i < numbersArray.Length; i++)
            {
                total += numbersArray[i];

            }

            average = total / numbersArray.Length;

            return average;

        }//end of AverageValueMethod

        private double HighestValueMethod(double[] numbersArray)
        {
            double highValue = numbersArray[0];
           

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (highValue < numbersArray[i])
                {

                    highValue = numbersArray[i];
                }


            }

            return highValue;

        }//end of HighestValueMethod

        private double LowestValueMethod(double[] numbersArray)
        {
            double lowValue = numbersArray[0];
           

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (lowValue > numbersArray[i])
                {

                    lowValue = numbersArray[i];
                }

            }

            return lowValue;

        }//end of LowestValueMethod


    }//end class
}//end namespace
