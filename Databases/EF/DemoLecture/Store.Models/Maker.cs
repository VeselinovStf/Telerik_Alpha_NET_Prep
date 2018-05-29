using System.Collections.Generic;

namespace Store.Models
{
    public class Maker
    {
        public Maker()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int DeliveryTime { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}