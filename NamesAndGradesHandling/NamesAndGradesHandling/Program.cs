using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesAndGradesHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a program that will read 10 names and scores from the input.txt file which I have supplied. 
            //Make sure to use exception handling when opening this text file.

            // Calculate the average, highest score, and lowest score

            // Create your own Exception for two test:

            // 1.Test if average is less 60.If so, display a message from the custom exception that says 
            //"Average not up to NC State standards. Class is eliminated."

            // 2.Test to see if there are any negative scores in the text file.If so, display a message from 
            //the custom exception that says "Invalid data. 
            //Please check file." Hint: to test this, edit the text file and put a negative score in. 

            //If average is 60 or greater with no negative scores, write the average, highest score and name, 
            //lowest score with name to an output.txt file(with exception handling when file is created).

            // Hint: Probably want to use StreamReader and StreamWriter to read the text file and write the output file..

            try
            {
                                                        
                const int NUMBERS = 10;
                
                StreamReader inputFile = null;
                StreamWriter writeFile;

                string[] namesArray = new string[NUMBERS];
                int[] numbersArray = new int[NUMBERS];
             
                int total = 0;
                int classAverage = 0;
                int highestGrade;
                int lowestGrade;
                string highestName;
                string lowestName;

                inputFile = File.OpenText("input.txt");
                 writeFile = File.CreateText("output.txt");

                int index = 0;
               
                while (index < numbersArray.Length && (namesArray[index] = inputFile.ReadLine()) != null)
                {

                    numbersArray[index] = int.Parse(inputFile.ReadLine());

                    //namesArray[index] = inputFile.ReadLine();

                    total += numbersArray[index];
                    index++;
               
                }//end while
                                                                                                              
                    inputFile.Close();

                 highestGrade = getHighestGrade(numbersArray);
                 lowestGrade = getLowestGrade(numbersArray);

                 highestName = getHighestName(numbersArray, namesArray);
                 lowestName = getLowestName(numbersArray, namesArray);


                classAverage = total / 10;
               

                if (classAverage >= 60)
                {
                    Console.WriteLine("Name: {0} Highest Grade: {1}", highestName, highestGrade);
                    Console.WriteLine("Name: {0} Lowest Grade: {1}", lowestName, lowestGrade);
                    Console.WriteLine("Class average: {0}", classAverage);

                    //write to file
                    writeFile.WriteLine("Class average: {0}", classAverage);                    
                    writeFile.WriteLine("Name: {0} Highest Grade: {1}", highestName, highestGrade);
                    writeFile.WriteLine("Name: {0} Lowest Grade: {1}", lowestName, lowestGrade);


                }//end try
              
                else
                {

                    Console.WriteLine("Name: {0} Highest Grade: {1}", highestName, highestGrade);
                    Console.WriteLine("Name: {0} Lowest Grade: {1}", lowestName, lowestGrade);

                    //thrown exception on average that does not qualify
                    throw new standardException();

                }//end else
                                                        
                 writeFile.Close();

            }//end try

            catch (openFileExpection o)
            {
                o.openFileChecker();

            }//end catch

            catch (fileException f)
            {
                f.fileChecker();
                
            }//end catch

            catch(standardException s)
            {               
                s.standardsChecker();

            }//end catch
            catch(negativeException n)
            {
                n.negativeChecker();

            }//end catch
        

            Console.ReadLine();

        }//end static void main
    

        public static int getHighestGrade(int [] array)
        {
            int highestGrade = array[0];
           
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > highestGrade)
                {
                    highestGrade = array[index];

                   
                }//end if


            }//end for

            return highestGrade;

        }//end method 

        public static string getHighestName(int [] array, string [] secondArray)
        {
            int highestGrade = array[0];

            string highestName = secondArray[0];

            for (int index = 1; index < array.Length; index++)
            {
                for(int i = 1; i < secondArray.Length; i++)
                {

                    if (array[i] > highestGrade)
                    {
                            highestName = secondArray[i];
                            

                    }//end if


                }//end for
               

            }//end for

            return highestName;
        }//end method 

        public static string getLowestName(int [] array, string [] secondArray)
        {
            int lowestGrade = array[0];

            string lowestName = secondArray[0];

            for (int index = 1; index < array.Length; index++)
            {

                for(int i = 1; i < secondArray.Length; i++)
                {
                    if (array[i] < lowestGrade)
                    {
                        lowestName = secondArray[i];

                    }//end if


                }//end for 
               
            }//end for

            return lowestName;

        }//end method 

        public static int getLowestGrade(int [] array)
        {
            int lowestGrade = array[0];

            for(int index = 1; index < array.Length; index++)
            {
                if (array[index] < lowestGrade)
                {
                    lowestGrade = array[index];

                }//end if

            }//end for

            return lowestGrade;

        }//end method
        
    }//end class

    class fileException : Exception
    {
        public void fileChecker()
        {
            Console.WriteLine("File was not found!");

        }//end void method
    }//end class

    class openFileExpection : Exception
    {
        public void openFileChecker()
        {
            Console.WriteLine("File could not be created or opened");

        }//end void method

    }//end class

    class standardException : Exception {


        public void standardsChecker()
        {

            Console.WriteLine("Average not up to NC State standards. Class is eliminated.");
        }//end method


    }//end class

    class negativeException : Exception
    {
        public void negativeChecker()
        {

            Console.WriteLine("Invalid data");
        }//end method

    }//end class

  
}//end namepsace
