using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp
{
    class Program
    {
        static String[] board = new String[9];
        static int counter = 0;
        static String playAgain = "Y";

       static void initialize()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = i.ToString(); 

            }//end for 

        }//end of void initialize method

        static void playAgainMsg(String message)
        {
            Console.WriteLine(message + " Do you want to play again" + " y for yes and n for no");
            if (Console.ReadLine().Equals("Y"))
            {
                playAgain.Equals("Y");

            }//end if

            else
            {
                playAgain.Equals("N");

            }//end else


        }//end of void playAgainMsg method

        static void Main(string[] args)
        {

            Intro();
            while (playAgain.Equals("Y"))
            {
                initialize();

                while (theWinner() == false && counter < 9)
                {

                    Data("X");

                    if (theWinner() == true)
                    {
                        Data("O");
                        break;


                    }//end if 

                }//end while
                if (theWinner() == true)
                {
                    playAgainMsg("You Won! ");

                }//end while
                else
                {

                    playAgainMsg("You Lose");
                }
               

            }//end while
                   
           
        }//end of void main


        static void Data(String player)
        {
            Console.Clear();
            Console.WriteLine("Player: " + player);
            int selection;

            while (true)
            {
                Console.WriteLine("Enter a number between 0 and 9 ");
                drawBoard();
                selection = Convert.ToInt32(Console.ReadLine());

                //validation purposes
                if (selection < 0 || selection > 9 || (board[selection].Equals("X") || board[selection].Equals("O")))
                {
                    Console.WriteLine("Invalid Selection");

                }//end if
                else
                {
                    break;
                }//end else             
            }//end while
            board[selection] = player;

        }//end of void Data method

        static void drawBoard()
        {
            for (int i = 0; i < 7; i+=3)
            {

                Console.WriteLine(board[i] + "|" + board[i + 1] + "|" + board[i + 2]);
               

            }//end for 


        }//end of void board method

        static Boolean theWinner()
        {

            for (int i = 0; i < 7; i+=3)
            {
                if (board[i].Equals(board[i + 1]) && board[i + 1].Equals(board[i+2]))
                {

                    return true;

                }//end if

            }//end for

            if (board[0].Equals(board[3]) && board[3].Equals(board[6]))
            {
                return true;
            }//end if
            if (board[1].Equals(board[4]) && board[4].Equals(board[7]))
            {
                return true;
            }//end if
            if (board[2].Equals(board[5]) && board[3].Equals(board[8]))
            {
                return true;
            }//end if
            if (board[2].Equals(board[4]) && board[4].Equals(board[6]))
            {
                return true;
            }//end if
            if (board[0].Equals(board[4]) && board[4].Equals(board[8]))
            {
                return true;
            }//end if

            return false;


        }//end of boolean winner method

        static void Intro()
        {
            Console.Title = ("Tic Tac Toe Console App");
            Console.WriteLine("Tic Tac Toe Game ");
            Console.WriteLine("Press any key to play");
            Console.ReadLine();
            Console.Clear();

        }//end of void Intro method 


    }//end class
}//end namespace
