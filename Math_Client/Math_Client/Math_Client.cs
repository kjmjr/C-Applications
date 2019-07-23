using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Library;

namespace Math_Client
{
    class Math_Client
    {
        static void Main(string[] args)
        {
           

            //create a reference to the library and then test it here
            Library ml = new Library();

            //calling our three overloaded methods
            int First_largest_number = ml.Large_Number_Method(13, 40);

           
            Console.WriteLine("The largest number in group 1 is " + First_largest_number);

            int Second_largest_number = ml.Large_Number_Method(15, 61, 50);

            Console.WriteLine("The largest number in group 2 is " + Second_largest_number);

            int Third_largest_number = ml.Large_Number_Method(25, 42, 67, 80);

            Console.WriteLine("The largest number in group 3 is " + Third_largest_number);



            Console.ReadLine();


        }//end static void main
    }//end class
}//end namespace
