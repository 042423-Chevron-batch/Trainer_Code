using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsApiModels
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

        // this constructor will take the data from the Chinook Db (for demo purposes)
        public Person(int personIntId, string fname, string lname, string email)
        {
            this.PersonIntId = personIntId;
            this.Fname = fname;
            this.Lname = lname;
            this.Email = email;
        }

        //field
        public readonly int age = 0;
        public Guid PersonId { get; set; } = Guid.NewGuid();// when you create a property with a setter, C# creates a private backing variable of the same name for you. YOu don't see it.
        public int PersonIntId { get; set; }
        private string fname;
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                if (value.Length > 10)
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
        public string Email { get; set; }

        //TODO add a speak method to inherit

    }
}