using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Math_Library
{
    // 1. Create a math library with 3 methods with the same name(overload) :

    //First method accepts 2 integer parameters and returns the larger number.

    // Second method accepts 3 integer parameters and returns the larger number.

    // Third method accepts 4 integer parameters and returns the larger number.

    //  2. Create a console application that will use and test your library methods.

    // Submit 2 zip files here (library project and console project)

    /// <summary>
    /// xml documentation
    /// </summary>
    public class Library
    {
        /// <summary>
        ///  accepts two integers and returns the larger integer
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>

        public int Large_Number_Method(int num1, int num2)
        {

            int maximumValue = Math.Max(num1, num2);

            return maximumValue;
        }//end public int method

        /// <summary>
        ///  accepts three integers and returns the larger integer
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public int Large_Number_Method(int num1, int num2, int num3)
        {

            int[] numberSet = { num1, num2, num3 };

            int maximumValue = numberSet.Max();

            return maximumValue;
        }//end public int method

        /// <summary>
        ///  accepts four integers and returns the larger integer
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <returns></returns>
        public int Large_Number_Method(int num1, int num2, int num3, int num4)
        {

            int[] numberSet = { num1, num2, num3, num4 };

            int maximumValue = numberSet.Max();

            return maximumValue;
        }//end public int method

    }//end class
}//end namespace
