using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        char operation = ' '; 
    
         double NumOne = 0.0;

        public MainWindow()
        {
            InitializeComponent();

        }


        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
   
            btn_one_check();
    
        }//end btnOne click

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
           
            btn_two_check();

        }//end btnTwo click

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {

            btn_three_check();


        }//end btnThree click

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            btn_four_check();

        }//end btnFour click

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            btn_five_check();


        }//end btnFive click

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            btn_six_check();

        }//end btnSix click

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            btn_seven_check();


        }//end btnSeven click

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            btn_eight_check();


        }//end btnEight click

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            btn_nine_check();

        }//end btnNine click

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            btn_zero_check();

        }//end btnZero click

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtShowAnswer.Clear();
            NumOne = 0.0;
            operation = ' ';
           
           
        }//end btnClear click
      
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

            NumOne = Convert.ToInt32(txtShowAnswer.Text);

            operation = '+';

            txtShowAnswer.Text = "0";
             
        }//end btnPlus click

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
        
            NumOne = Convert.ToInt32(txtShowAnswer.Text);

            operation= '-';

            txtShowAnswer.Text = "0";
        }//end btnMinus click


        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            NumOne = Convert.ToInt32(txtShowAnswer.Text);

            operation = '*';

            txtShowAnswer.Text = "0";
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            NumOne = Convert.ToInt32(txtShowAnswer.Text);

            operation = '/';

            txtShowAnswer.Text = "0";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
           
            switch (operation)
                {

                    case '+':
            
                    txtShowAnswer.Text = Convert.ToString(Convert.ToDouble(txtShowAnswer.Text) + NumOne);
                     
                        break;
                    case '-':
                 
                    txtShowAnswer.Text = Convert.ToString(NumOne - Convert.ToDouble(txtShowAnswer.Text));

                    break;

                case '*':

                    txtShowAnswer.Text = Convert.ToString(Convert.ToDouble(txtShowAnswer.Text) * NumOne);

                    break;

                case '/':

                       txtShowAnswer.Text = Convert.ToString(NumOne / Convert.ToDouble(txtShowAnswer.Text));
                    break;

                }//end switch
                 
            //txtShowAnswer.Text = answer.ToString();
  
        }//end btnEquals click
          
        public void btn_one_check()
        {
         
            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "1";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "1";

            } //end else            
        }//end void
        public void btn_two_check()
        {
            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "2";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "2";

            } //end else            
        }//end void
    
        
        public void btn_three_check()
        {

            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "3";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "3";

            } //end else            
        }//end void

        public void btn_four_check()
        {
            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "4";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "4";

            } //end else            
        }//end void

        public void btn_five_check()
        {
            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "5";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "5";

            } //end else            
        }//end void

        public void btn_six_check()
        {
            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "6";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "6";

            } //end else            
        }//end void

        public void btn_seven_check()
        {
            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "7";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "7";

            } //end else            
        }//end void
        public void btn_eight_check()
        {
            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "8";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "8";

            } //end else            
        }//end void

        public void btn_nine_check()
        {

            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "9";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "9";

            } //end else            
        }//end void

        public void btn_zero_check()
        {

            if (txtShowAnswer.Text == "0")
            {
                txtShowAnswer.Text = "0";

            }//end if

            else
            {
                txtShowAnswer.Text = txtShowAnswer.Text + "0";

            } //end else            
        }//end void

      
    }//end class
}//end namepspace
