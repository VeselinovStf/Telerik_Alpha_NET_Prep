using System.Collections.Generic;

namespace EFCodeFirst.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Book> books { get; set; }
    }
}
