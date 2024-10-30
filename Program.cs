using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book0 = new Book();
            Book book1 = new Book();
            System.Console.WriteLine(book0.ID);
            System.Console.WriteLine(Book.BookCount);
        }
    }
}