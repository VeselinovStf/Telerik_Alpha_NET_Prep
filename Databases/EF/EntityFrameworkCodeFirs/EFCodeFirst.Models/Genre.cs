using System.Collections.Generic;

namespace EFCodeFirst.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Genre ParentGanre { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
