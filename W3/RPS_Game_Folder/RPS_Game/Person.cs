using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsGame1
{
    public class Person
    {
        public Person() { }

        public Person(string fname, string lname, int age)
        {
            this.age = age;
            this.Fname = fname;
            this.Lname = lname;
        }

        //field
        public readonly int age = 0;
        public Guid PersonId { get; set; } = Guid.NewGuid();// when you create a property with a setter, C# creates a private backing variable of the same name for you. YOu don't see it.

        private string fname;
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                if (value.Length > 4)
                {
                    throw new FormatException();// TODO find out why this exception didn't crash the program
                }
                else
                {
                    this.fname = value;
                }
            }
        }

        public string Lname { get; set; }// this is a "property"

        //TODO add a speak method to inherit

    }
}