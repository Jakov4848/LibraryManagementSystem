using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book0 = new Book("Sarnia", "Hilary Ford", "1974", 276, "English");
            Book book1 = new Book("Souls for sale","Rupert Hughes","1922", 250, "English");
           


            System.Console.WriteLine($"{book0.ID},{book0.Title},{book0.Author},{book0.PublicationYear}, {book0.NumOfPages}, {book0.Language}");
            System.Console.WriteLine($"{book1.ID},{book1.Title},{book1.Author},{book1.PublicationYear}, {book1.NumOfPages}, {book1.Language}");

            System.Console.WriteLine(Book.bookCount);
        }
    }
}