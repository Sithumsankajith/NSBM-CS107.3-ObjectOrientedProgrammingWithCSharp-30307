using System;

namespace BookApplication
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Book myBook = new Book();


            myBook.Title = "The Great Gatsby";
            myBook.Author = "F. Scott Fitzgerald";


            Console.WriteLine("Book Title: " + myBook.Title);
            Console.WriteLine("Book Author: " + myBook.Author);


            Console.ReadKey();
        }
    }
}
