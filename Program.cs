using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book0 = new Book();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();


            System.Console.WriteLine($"{book0.ID},{book1.ID},{book2.ID},{book3.ID}");
            System.Console.WriteLine(Book.BookCount);
        }
    }
}