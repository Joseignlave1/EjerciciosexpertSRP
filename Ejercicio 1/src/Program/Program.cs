using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve shelve = new Shelve(10);
            Book book = new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", "ISBN-12345");
            shelve.AddBook(book);
            int bookCount = shelve.GetBooksCount();
            Console.WriteLine("La estantería contiene " + bookCount + " libro(s).");
            
        }
    }
}