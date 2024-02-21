using System;

class LibraryBook
{
    public string Title { get; }
    public string Author { get; }
    public bool Available { get; private set; }

    public LibraryBook(string title, string author)
    {
        Title = title;
        Author = author;
        Available = true;
    }

    public void BorrowBook()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' by {Author} is not available.");
        }
    }

    public void ReturnBook()
    {
        if (!Available)
        {
            Available = true;
            Console.WriteLine($"Book '{Title}' by {Author} has been returned.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' by {Author} is already available.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        LibraryBook book1 = new LibraryBook("1984", "George Orwell");
        LibraryBook book2 = new LibraryBook("To Kill a Mockingbird", "Harper Lee");
        LibraryBook book3 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald");

        
        book1.BorrowBook();
        book2.BorrowBook();
        book3.BorrowBook();
        book1.BorrowBook();  
        book2.ReturnBook();
        book3.ReturnBook();

        
        Console.WriteLine("\nLibrary Status:");
        Console.WriteLine($"Book '{book1.Title}' by {book1.Author} - Available: {book1.Available}");
        Console.WriteLine($"Book '{book2.Title}' by {book2.Author} - Available: {book2.Available}");
        Console.WriteLine($"Book '{book3.Title}' by {book3.Author} - Available: {book3.Available}");

        Console.ReadLine();
    }
}
