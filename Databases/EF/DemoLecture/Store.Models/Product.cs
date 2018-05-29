using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        public Product()
        {
            this.Makers = new HashSet<Maker>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public ProductType Type { get; set; }

        public int Amount { get; set; }

        public virtual ICollection<Maker> Makers { get; set; }
    }
}
