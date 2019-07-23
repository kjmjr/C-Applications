using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentFileThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //student1.txt and student2.txt are two files with 1000 grades in each.
            //Use threading methodology to open and read each file, calculate the averages 
            // of student1 and student 2, and display the averages on the screen.
            // Finally, display the group who had the higher average.


            try
            {
              
                studentOne s1 = new studentOne();             
                studentTwo s2 = new studentTwo();

                int s1Avg = s1.averageStudentOne();
                int s2Avg = s2.averageStudentTwo();

                if (s1Avg < s2Avg)
                {
                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.WriteLine("The average grade for the student two file is " + s2.averageStudentTwo());
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Group 2 of the students has the higher average");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("The average grade for the student one file is " + s1.averageStudentOne());
                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

                }//end if
                else if (s1Avg > s2Avg)
                {

                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.WriteLine("The average grade for the student one file is " + s1.averageStudentOne());
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Group 1 of the students has the higher average");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("The average grade for student two is " + s2.averageStudentTwo());
                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");


                }//end else if

                else
                {
                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.WriteLine("The average grade for the student one file is " + s1.averageStudentOne());
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("The averages are equal");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("The average grade for the student two file is " + s2.averageStudentTwo());
                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");


                }//end else 
                
                   

               

                


                Console.ReadLine();

            }//end try
            catch (openFileExpection o)
            {
                o.openFileChecker();

            }//end catch



            Console.ReadLine();


        }//end static void main
    }//end class

    public class studentOne
    {

        public studentOne()
        {
            Thread s1 = new Thread(new ThreadStart(studentOneGrades));
            s1.Start();
            s1.Join();

        }//end constructor

        void studentOneGrades()
        {
            StreamReader StudentOneFile = null;

            int[] StudentOneArray = new int[1000];

            StudentOneFile = File.OpenText("studentOneFile.txt");

            int index = 0;

            while (index < StudentOneArray.Length && (StudentOneFile.ReadLine()) != null)
            {
                StudentOneArray[index] = int.Parse(StudentOneFile.ReadLine());

                //a b c d f checker
                if (StudentOneArray[index] > 90)
                {
                    Console.WriteLine("Student One's grade is " + StudentOneArray[index] + ", which " +
                        "makes it an A");

                }
                if (StudentOneArray[index] > 80)
                {
                    Console.WriteLine("Student One's grade is " + StudentOneArray[index] + ", which " +
                        "makes it an B");

                }
                if (StudentOneArray[index] > 70)
                {

                    Console.WriteLine("Student One's grade is " + StudentOneArray[index] + ", which " +
                        "makes it an C");
                }
                if (StudentOneArray[index] > 60)
                {
                    Console.WriteLine("Student One's grade is " + StudentOneArray[index] + ", which " +
                        "makes it an D");

                }
                if (StudentOneArray[index] < 60)
                {

                    Console.WriteLine("Student One's grade is " + StudentOneArray[index] + ", which " +
                        "makes it an F");
                }

               
                index++;

            }//end while



            StudentOneFile.Close();



        }//end void

        public int averageStudentOne()
        {
            StreamReader StudentOneFile = null;

            int[] StudentOneArray = new int[1000];

            StudentOneFile = File.OpenText("studentOneFile.txt");

            int index = 0;
            int total = 0;
            int average;

            while (index < StudentOneArray.Length && (StudentOneFile.ReadLine()) != null)
            {
                StudentOneArray[index] = int.Parse(StudentOneFile.ReadLine());


                total += StudentOneArray[index];
                index++;

            }//end while

            StudentOneFile.Close();

            return average = total / StudentOneArray.Length;

        }//end averageStudent



    }//end studentOne

    public class studentTwo
    {

        public studentTwo()
        {
            Thread s2 = new Thread(new ThreadStart(studentTwoGrades));
            s2.Start();
            s2.Join();

        }//end constructor

        void studentTwoGrades()
        {
            StreamReader StudentTwoFile = null;

            int[] StudentTwoArray = new int[1000];

            StudentTwoFile = File.OpenText("studentTwoFile.txt");

            int index = 0;

            while (index < StudentTwoArray.Length && (StudentTwoFile.ReadLine()) != null)
            {
                StudentTwoArray[index] = int.Parse(StudentTwoFile.ReadLine());

                //a b c d f checker
                if (StudentTwoArray[index] > 90)
                {
                    Console.WriteLine("Student Two's grade is " + StudentTwoArray[index] + ", which " +
                        "makes it an A");

                }
                if (StudentTwoArray[index] > 80)
                {
                    Console.WriteLine("Student Two's grade is " + StudentTwoArray[index] + ", which " +
                        "makes it an B");

                }
                if (StudentTwoArray[index] > 70)
                {

                    Console.WriteLine("Student Two's grade is " + StudentTwoArray[index] + ", which " +
                        "makes it an C");
                }
                if (StudentTwoArray[index] > 60)
                {
                    Console.WriteLine("Student Two's grade is " + StudentTwoArray[index] + ", which " +
                        "makes it an D");

                }
                if (StudentTwoArray[index] < 60)
                {

                    Console.WriteLine("Student Two's grade is " + StudentTwoArray[index] + ", which " +
                        "makes it an F");
                }


                index++;


            }//end while

            StudentTwoFile.Close();

        }//end void

        public int averageStudentTwo()
        {
            StreamReader StudentTwoFile = null;

            int[] StudentTwoArray = new int[1000];

            StudentTwoFile = File.OpenText("studentOneFile.txt");

            int index = 0;
            int total = 0;
            int average;

            while (index < StudentTwoArray.Length && (StudentTwoFile.ReadLine()) != null)
            {
                StudentTwoArray[index] = int.Parse(StudentTwoFile.ReadLine());


                total += StudentTwoArray[index];
                index++;

            }//end while

            StudentTwoFile.Close();

            return average = total / StudentTwoArray.Length;

        }//end averageStudent



    }//end studentTwo



    class openFileExpection : Exception
    {
        public void openFileChecker()
        {
            Console.WriteLine("File could not be created or opened");

        }//end void method

    }//end class





}//end namespace
