using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW
{
    class Program
    {
        static void Main(string[] args)
        {


            //Book list
            List<Book> myBooks = new List<Book>()
            {

                new Book() { ISBN = "1234-45-34-3939", Title = "The Long Road", Publisher = "New York", Price = 25.00, Copyright = 2016 },

                new Book() { ISBN = "988-65-34-9012", Title = "The Warrior", Publisher = "McGraw", Price = 55.00, Copyright = 2013 },

                new Book() { ISBN = "8712-45-84-2539", Title = "Yesterday", Publisher = "New York", Price = 67.00, Copyright = 2016 },

                new Book() { ISBN = "1234-78-99-3478", Title = "Programming Essentials", Publisher = "Dalton", Price = 35.00, Copyright = 2015 },

                new Book() { ISBN = "8356-89-33-3251", Title = "Hello World", Publisher = "Chicago Press", Price = 115.00, Copyright = 2016 }


            };

            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Display ISBN, Title, Publisher for all books where Publisher is New York: ");
            Console.WriteLine("__________________________________________________________________________");

            var bookList = from Book in myBooks
                       where Book.Publisher == "New York"               
                       select Book; 


            foreach (var book in bookList)
            {
                Console.WriteLine("{0} {1} {2}", book.ISBN, book.Title, book.Publisher);

            } //end foreach loop


            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Display all fields for all books in descending order by Copyright: ");
            Console.WriteLine("___________________________________________________________________");

            var orderedBooks = from book in myBooks
                              orderby book.Copyright descending
                              select book;

            //show results
            foreach (var book in orderedBooks)
            {
                Console.WriteLine("{0} {1} {2} {3:C} {4}", book.ISBN, book.Title, book.Publisher, book.Price, book.Copyright);

            } //end foreach loop




            Console.WriteLine("_______________________________________________________________________________________________");
            Console.WriteLine("Display all fields for all books in descending order by Copyright Where Publisher is New York: ");
            Console.WriteLine("_______________________________________________________________________________________________");


            var orderedBooks2 = from book in myBooks
                               orderby book.Copyright descending
                               where book.Publisher == "New York"
                               select book;

            //show results
            foreach (var book in orderedBooks2)
            {
                Console.WriteLine("{0} {1} {2} {3:C} {4}", book.ISBN, book.Title, book.Publisher, book.Price, book.Copyright);

            } //end foreach loop



            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("Display ISBN, Title for all books with copyright greater than 2015: ");
            Console.WriteLine("____________________________________________________________________");

            var greaterBook = from book in myBooks                                    
                       select book;  
           
            foreach (var book in greaterBook)
            {
                if (book.Copyright > 2015)
                {
                    Console.WriteLine("{0} {1}", book.ISBN, book.Title);

                }//end if
              

            } //end foreach loop

      
            Console.WriteLine("_______________________________________________________________________________________________________");
            Console.WriteLine(" Order the list in descending order by Title and display the " +
                "ISBN Title of the first book in the list: ");
            Console.WriteLine("_______________________________________________________________________________________________________");


            var orderedBooks3 = myBooks.OrderByDescending(i => i.Title).First();    

                Console.WriteLine("{0} {1}", orderedBooks3.ISBN, orderedBooks3.Title);
               

            Console.WriteLine("___________________________________________________________________________________");
            Console.WriteLine("Use LINQ to calculate the sum of the price for all books and display average cost: ");
            Console.WriteLine("___________________________________________________________________________________");

            double sum = myBooks.Sum(i => i.Price);
            double average = sum / 5.0;
            Console.WriteLine("{0:C}", average);



            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("Use LINQ to calculate a 3% markup of the price for each book and display the title " +
                "and markup price: ");
            Console.WriteLine("_______________________________________________________________________________________________________");

            double markupValue = 0.03;
            double markupCost = 0.0;

            var markupBooks = from book in myBooks
                              select book;

            foreach (var book in markupBooks)
            {

                markupCost = markupValue * book.Price;

                book.Price += markupCost;

                Console.WriteLine("{0} {1:C}", book.Title, book.Price);

            } //end foreach loop


            //pause program
            Console.ReadLine();


        }//end static void main
    }//end class
     
    class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public int Copyright { get; set; }




    }//end book class
}//end namespace
