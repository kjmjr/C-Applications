using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//two methods should be made, accelerate and brake
namespace CarClass
{
    class car
    {
        //our 3 instance variables
        private string year;
        private string make;
        private double speed;

        
        public car()
        {
            year = "2010";
            make = "Chevy Cobalt";
            speed = 0;

        }//end constructor

        public car(double s)
        {
            speed = s;

        }//end public car constructor with an argument

        public double accelerate(double a)
        {
                    
            return a + 5;

        }//end double accelerate method

        public double brake(double b)
        {          
             
            return b - 5;
        }//end double brake method
   

        public string getYear()
        {
            return year;

        }//returns the year

        public string getMake()
        {

            return make;
        }//returns the make


    }//end class car
}//end namepace
