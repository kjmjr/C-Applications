using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_ProductionWorker
{
    class Employee
    {

        //Instance vars
        private string name;
        private int number;


        //constructor
        public Employee()
        {
            name = "";
            number = 0;

        }//end constructor


        //setters and getters
        public string Name
        {

            set { name = value; }
            get { return name; }
        }

        public int Number
        {
            set { number = value; }
            get { return number; }


        }//end constructor
    }//end class


    //the next two classes will inherit the Employee class
    class ProductionWorker : Employee
    {
        private int shiftNumber;
        private double hourlyPay;

        public ProductionWorker()
        {

            shiftNumber = 0;
            hourlyPay = 0.0;

        }//end constructor


        //making our getters and setters
        public int ShiftNumber
        {
            set { shiftNumber = value; }
            get { return shiftNumber; }

        }

        public double HourlyPay
        {
            set { hourlyPay = value; }
            get { return hourlyPay; }


        }




    }//class

    class ShiftSupervisor : Employee
    {
        private double annualSalary;
        private double annualBonus;

        public ShiftSupervisor()
        {

            annualSalary = 0.0;
            annualBonus = 0.0;

        }//end constructor


        //making our getters and setters
        public double AnnualSalary
        {
            set { annualSalary = value; }
            get { return annualSalary; }

        }

        public double AnnualBonus
        {
            set { annualBonus = value; }
            get { return annualBonus; }


        }

    }//end class

}//end namespace
