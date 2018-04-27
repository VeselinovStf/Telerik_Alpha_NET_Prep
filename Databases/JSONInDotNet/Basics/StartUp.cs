using System;
using System.Web.Script.Serialization;

namespace Basics
{
    public class StartUp
    {
        public static void Main()
        {
            //Serialize vith JSON build-in serializer
            Book book = new Book(
                1,
                "Dog Story",
                "Long story for little dog",
                "Comedy",
                "Fantasy"
                );

            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(book);
            Console.WriteLine(json);

            //Deserialize
            var book2 = serializer.Deserialize<Book>(json);
            Console.WriteLine(book2);
        }
    }
}