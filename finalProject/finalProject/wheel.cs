using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace finalProject
{
    class wheel
    {

        private int RandomValue;
        private char letter;
        private int Total;
      

        public wheel()
        {
            RandomValue = 0;
            letter = ' ';
            Total = 0;


        }//end empty constructor


        public int getRandomNumber
        {
            set { RandomValue = value; }
            get { return RandomValue; }


        }//end getter and setter method 

        public char getLetterValue
        {

            set { letter = value; }
            get { return letter; }

        }//end getter and setter method 
     
        public int getTotal
        {

            set { Total = value; }
            get { return Total; }
        }//end getter and setter method 


        public int getSpin()
        {
            //initializing array to the size of 10 with that amount of elements
            const int SIZE_OF_ARRAY = 10;
            int[] playerAmount = new int[SIZE_OF_ARRAY] { 100,300,500, 700, 900,
                    2000, 3000, 5000, -1000, 0};

            int r = 0;

            //simulates the random number object
            Random rand = new Random();

            r = rand.Next(10) + 1;

            //matching each item up with the array
            if (r == 1)
            {
                RandomValue = playerAmount[0];

            }//end if

            else if (r == 2)
            {
                RandomValue = playerAmount[1];

            }//end else if

            else if (r == 3)
            {
                RandomValue = playerAmount[2];

            }//end else if

            else if (r == 4)
            {

                RandomValue = playerAmount[3];
            }//end else if

            else if (r == 5)
            {
                RandomValue = playerAmount[4];

            }//end else if

            else if (r == 6)
            {
                RandomValue = playerAmount[5];

            }//end else if

            else if (r == 7)
            {
                RandomValue = playerAmount[6];

            }//end else if
            else if (r == 8)
            {
                RandomValue = playerAmount[7];

            }//end else if


            else if (r == 9)
            {
                RandomValue = playerAmount[8];

            }//end if

            else
            {
                RandomValue = playerAmount[9];

            }//end else  



            return RandomValue;

        }//end void spin method 


        public int calculateMoney(int r)
        {
            RandomValue = r;
            //calculating the total
            Total += RandomValue;

            return Total;

        }//end method

        public int getTotalMoney()
        {
            return Total;
        }//end method 
    

        public Boolean getSelectedLetter(char l)
        {
            Boolean correct = true;

            if (l == 'S')
            {
                correct = true;

            }

            else if (l == 'O')
            {
                correct = true;

            }
            else if (l == 'F')
            {
                correct = true;

            }
            else if (l == 'T')
            {
                correct = true;

            }
            else if (l == 'W')
            {
                correct = true;

            }
            else if (l == 'A')
            {
                correct = true;

            }
            else if (l == 'R')
            {
                correct = true;

            }
            else if (l == 'E')
            {
                correct = true;

            }
            else if (l == 'D')
            {
                correct = true;
            }

            else if (l == 'V')
            {
                correct = true;

            }
            else if (l == 'L')
            {
                correct = true;

            }
            else if (l == 'P')
            {
                correct = true;

            }

            else
            {
                correct = false;

            }

            return correct;
        }


    }//end class

}//end namespace