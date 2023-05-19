using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dictionaryDemo1
{
    public class Person
    {
        public Person(string name, int quantity)
        {
            Name = name;
            this.quantity = quantity;
        }

        public string Name { get; set; }
        public int quantity { get; set; }



    }
}