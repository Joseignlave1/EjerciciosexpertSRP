using System;
using System.Collections.Generic;

namespace SRP
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        public Book(string title, string author, string code)
        {
            Title = title;
            Author = author;
            Code = code;
        }
    }

    public class LibrarySector
    {
        private int shelvesCount;

        public LibrarySector()
        {
            shelvesCount = 0;
        }

        public int GetShelvesCount()
        {
            return shelvesCount;
        }

        public void AddShelf()
        {
            shelvesCount++;
        }
    }

    public class Shelve
    {
        private List<Book> books;
        private int capacity;

        public Shelve(int capacity)
        {
            books = new List<Book>();
            this.capacity = capacity;
        }

        public int GetBooksCount()
        {
            return books.Count;
        }

        public bool AddBook(Book book)
        {
            if (books.Count < capacity)
            {
                books.Add(book);
                return true;
            }
            return false;
        }
    }
}
// el código no cumplía con el patron SRP ya que los métodos estante y sector tienen que ser clases a parte, debido a que yo puedo leer un libro sin necesidad de sacarlo de un estante ni mucho menos de un sector
// por lo tanto esa clase tenía mas de una responsabilidad esencial.