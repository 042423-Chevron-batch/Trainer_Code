using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rps_Models
{
    public class Product
    {
        public Product()
        {
        }

        // this constructor is useful for when we need to extract a product from the Db and display it's data to the user.
        public Product(Guid pid, string pname, int q, string d)
        {
            this.ProductId = pid;
            this.Description = d;
            this.ProductName = pname;
            this.Quantity = q;
        }

        public Guid ProductId { get; set; }// we don't have to creae a Guid here automatically bc the Db will be seeded with products and already have ids
        public string ProductName { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; }
        // public byte[] image { get; set; }
    }
}