using Newtonsoft.Json;
using System;

namespace JSONdotNEt
{
    public class StartUp
    {
        public static void Main()
        {
            Book book = new Book(
               1,
               "Dog Story",
               "Long story for little dog",
               "Comedy",
               "Fantasy"
               );

            var bookJson = JsonConvert.SerializeObject(book);

            var bookBook = JsonConvert.DeserializeObject<Book>(bookJson);

            Console.WriteLine(bookJson);
            Console.WriteLine(bookBook);
        }
    }
}