using EFCodeFirst.Models;
using System.Data.Entity;

namespace EFCodeFirst.CLI.Engine.Data
{
    public class LibraryDbContex : DbContext
    {
        public LibraryDbContex()
            :base("LibraryCodeFirst")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
