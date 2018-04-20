using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryInfo
{
    public class Library
    {
        private string name;
        private List<Book> books;
        
        public string Name { get => name;  }
        public List<Book> Books { get => books; }

        public Library(string name)
        {
            this.name = name;
            this.books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentException("You must add book with all info in it");
            }

            this.books.Add(book);
        }

        public IEnumerable<Book> FindBookByAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("Author must be string");
            }

            var searchBook = this.books.Where(x => x.Author == author);

            return searchBook;
        }

        public string BookInfo(string bookName)
        {
            string info = this.books.Where(x => x.Name == bookName).ToString();

            return info;
        }

        public void RemoveBook(Book book)
        {
            this.books.Remove(book);
        }
    }
}
