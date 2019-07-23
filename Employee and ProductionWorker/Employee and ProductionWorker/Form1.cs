using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_and_ProductionWorker
{
    public partial class EmployeeAndProductionWorker : Form
    {
        public EmployeeAndProductionWorker()
        {
            InitializeComponent();
        }
     
        private void radProductionWorker_CheckedChanged(object sender, EventArgs e)
        {

            txtShiftNumber.Visible = radProductionWorker.Checked;
            txtHourlyPayRate.Visible = radProductionWorker.Checked;
            lblProductionWorkerInfo.Visible = radProductionWorker.Checked;
            lblShiftNumber.Visible = radProductionWorker.Checked;
            lblHourlyPayRate.Visible = radProductionWorker.Checked;

            lblShiftSupervisorInfo.Visible = radShiftSupervisor.Checked;
            lblAnnualSalary.Visible = radShiftSupervisor.Checked;
            txtAnnualSalary.Visible = radShiftSupervisor.Checked;
            lblAnnualProductionBonus.Visible = radShiftSupervisor.Checked;
            txtAnnualProductionBonus.Visible = radShiftSupervisor.Checked;

            



        }//end radProductionWorker void method

        private void radShiftSupervisor_CheckedChanged(object sender, EventArgs e)
        {

            txtShiftNumber.Visible = radProductionWorker.Checked;
            txtHourlyPayRate.Visible = radProductionWorker.Checked;
            lblProductionWorkerInfo.Visible = radProductionWorker.Checked;
            lblShiftNumber.Visible = radProductionWorker.Checked;
            lblHourlyPayRate.Visible = radProductionWorker.Checked;

            lblShiftSupervisorInfo.Visible = radShiftSupervisor.Checked;
            lblAnnualSalary.Visible = radShiftSupervisor.Checked;
            txtAnnualSalary.Visible = radShiftSupervisor.Checked;
            lblAnnualProductionBonus.Visible = radShiftSupervisor.Checked;
            txtAnnualProductionBonus.Visible = radShiftSupervisor.Checked;

          


        }//end radShiftSupervisor void method 

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
              
            //calling the void method 
            displayOutput();


        }//end void btnCreateObject method

        private  void displayOutput()
        {

          
            if (radProductionWorker.Checked)
            {
                try
                {

                    ProductionWorker pw = new ProductionWorker();
                
                    pw.Name = txtName.Text;
                    pw.Number = Convert.ToInt16(txtNumber.Text);

                    pw.ShiftNumber = Convert.ToInt16(txtShiftNumber.Text);

                    pw.HourlyPay = Convert.ToDouble(txtHourlyPayRate.Text);


                    if (pw.Number < 0 || pw.ShiftNumber < 0 || pw.HourlyPay < 0)
                    {

                        MessageBox.Show("Input can not be lower than 0");

                        if (pw.Number < 0)
                        {
                            txtNumber.Text = " ";

                        }

                        else if (pw.ShiftNumber < 0)
                        {

                            txtShiftNumber.Text = " ";
                        }

                        else if (pw.HourlyPay < 0)
                        {
                            txtHourlyPayRate.Text = " ";

                        }

                        txtName.Text = " ";


                    }//end if

                   
                    else if (pw.ShiftNumber > 3)
                    {
                        MessageBox.Show("Shift number can not be higher than 3");
                        txtShiftNumber.Text = " ";

                    }//end else if 

                    else if (pw.Name == " ")
                    {

                        MessageBox.Show("Please put a name in the text box");
                        txtName.Text = " ";
                    }

                    else
                    {

                        MessageBox.Show("Employee Name: " + pw.Name
                       + "\nEmployee Number: " + pw.Number
                       + "\nShift Number: " + pw.ShiftNumber
                       + "\nHourly Pay Rate: $" + pw.HourlyPay + " dollars");


                    }//end else 



                }//end try

                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }//end catch
                               

            }//end if 

            else
            {

                try
                {

                    ShiftSupervisor ss = new ShiftSupervisor();

                    ss.Name = txtName.Text;
                    ss.Number = Convert.ToInt16(txtNumber.Text);

                    ss.AnnualSalary = Convert.ToDouble(txtAnnualSalary.Text);

                    ss.AnnualBonus = Convert.ToDouble(txtAnnualProductionBonus.Text);

                    if (ss.Number < 0 || ss.AnnualBonus < 0 || ss.AnnualSalary < 0)
                    {

                        MessageBox.Show("Input can not be lower than 0");

                        if (ss.Number < 0)
                        {
                            txtNumber.Text = " ";

                        }

                        else if (ss.AnnualBonus < 0)
                        {

                            txtAnnualProductionBonus.Text = " ";
                        }

                        else if (ss.AnnualSalary < 0)
                        {
                            txtAnnualSalary.Text = " ";

                        }              
                                           
                        txtName.Text = " ";

                    }//end if

                    else if (ss.Name == " ")
                    {

                        MessageBox.Show("Please put a name in the text box");
                        txtName.Text = " ";
                    }

                    else
                    {
                        MessageBox.Show("Name of Shift Supervisor: " + ss.Name
                       + "\nShift Supervisor Number: " + ss.Number
                       + "\nAnnual Salary: $" + ss.AnnualSalary + " dollars"
                       + "\nAnnual Bonus: $" + ss.AnnualBonus + " dollars");

                    }//end else 


                }//end try

                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }//end catch
              

               

            }//end else

        }//end void displayOutput method 

        
    }//end class
}//end namespace
