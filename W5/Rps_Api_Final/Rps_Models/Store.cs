using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rps_Models
{
    public class Store
    {
        public Guid StoreId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public List<Product>? Inventory { get; set; }// we will need to keep the quantity of that product on the product instance itself.

    }
}