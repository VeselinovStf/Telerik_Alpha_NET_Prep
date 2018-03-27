using System;
using System.Collections.Generic;

namespace LibraryInfo
{
    public class StartUp
    {
        public static void Main()
        {
            var library = LibraryTest.Library;

            string autthor = "Steaven King";
            var kingBooks = library.FindBookByAuthor(autthor);

            Console.WriteLine("My Library-------");
            PrintBooks(kingBooks);

            for (int i = 0; i < library.Books.Count; i++)
            {
                if (library.Books[i].Author == autthor)
                {
                    library.RemoveBook(library.Books[i]);
                    i--;
                }
            }
              
            Console.WriteLine("Removing Some Books");

            PrintBooks(library.Books);
        }

     

        private static void PrintBooks(IEnumerable<Book> library)
        {
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
