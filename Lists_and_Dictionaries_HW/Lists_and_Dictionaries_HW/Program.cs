using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class of Book with 5 properties - ISBN, author, title, publisher, copyright date

//In the main method, create 5 instances of the Book class with different data for each

//Create a LIST and add each of the 5 objects to the LIST

//Use a foreach loop to display the ISBN, author, title, publisher, and copyright date in the LIST

//Create a DICTIONARY and add each of the 5 objects(key should be ISBN)

//Display author, title, publisher, copyright date for each book

namespace Lists_and_Dictionaries_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book()
            {
                ISBN = "47568" ,
                author = "Scott Fitzegerald",
                title = "The Great Gatsby",
                publisher = "Scribner's",
                copyright_date = "1925"
            };

            Book b2 = new Book()
            {
                ISBN = "34567" ,
                author = "Christopher Paolini",
                title = "Eragon",
                publisher = "Alfred A. Knopf",
                copyright_date = "2002"
            };

            Book b3 = new Book()
            {
                ISBN = "34565",
                author = "Dav Pilkey",
                title = "Captain Underpants",
                publisher = "Blue Sky",
                copyright_date = "1997"
            };
                Book b4 = new Book()
                {
                    ISBN = "65767",
                    author = "Suzanne Collins",
                    title = "Mokingjay",
                    publisher = "Scholastic Corporation",
                    copyright_date = "2010"
                };
                Book b5 = new Book()
                {
                    ISBN = "56777",
                    author = "Dan Slott, Christos Gage, David Hine, Fabrice Sapolsky",
                    title = "Spider-Verse",
                    publisher = "Marvel Comics",
                    copyright_date = "2015"
                };

            //Book list with 5 added objects
            List<Book> BookList = new List<Book>();

            BookList.Add(b1);
            BookList.Add(b2);
            BookList.Add(b3);
            BookList.Add(b4);
            BookList.Add(b5);


            foreach (Book book in BookList)
            {
                Console.WriteLine(book.author);

                Console.WriteLine();

            }//end foreach loop

            //Dictionary
            Dictionary<string, Book> Dictionary_Book = new Dictionary<string, Book>();
            Dictionary_Book.Add(b1.ISBN, b1);
            Dictionary_Book.Add(b2.ISBN, b2);
            Dictionary_Book.Add(b3.ISBN, b3);
            Dictionary_Book.Add(b4.ISBN, b4);
            Dictionary_Book.Add(b5.ISBN, b5);

            Console.WriteLine();

            //now we can print specific record using our key
            Console.WriteLine("First record in the dictionary: " + Dictionary_Book["47568"].author);

            Console.WriteLine();

            foreach (Book book in Dictionary_Book.Values)
            {
                Console.WriteLine("ISBN: {0} | Author: {1} | Title: {2} | Publisher: {3} | Copyright date: {4}", 
                   book.ISBN, 
                   book.author,
                   book.title, 
                   book.publisher,
                   book.copyright_date);

                Console.WriteLine();


            }//end foreach loop


            Console.ReadLine();

        }//end static void main
    }//end class



    class Book
    {
        public string ISBN { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string publisher { get; set; }
        public string copyright_date { get; set; }


    }//end class












}//end namespace
