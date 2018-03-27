namespace LibraryInfo
{
    public class LibraryTest
    {
        private static Library library ;

        static LibraryTest()
        {
            library = new Library("Test");
            library.AddBook(new Book("IT", "Steaven King", "self", 1987, 2332323));
            library.AddBook(new Book("Pet Cenetery", "Steaven King", "self", 1992, 898678));
            library.AddBook(new Book("Meditation", "John Doe", "self", 9999, 32423423));
            library.AddBook(new Book("The Shining", "Steaven King", "self", 1986, 6564645));
        }

        
        public static Library Library { get => library;  }
    }
}
