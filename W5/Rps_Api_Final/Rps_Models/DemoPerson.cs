using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rps_Models// namespace is a logic grouping of related functionality.
{
    public class Person
    {
        public Person() { }

        public Person(string fname, string lname)
        {
            //this.age = age;
            this.FirstName = fname;
            this.LastName = lname;
        }

        // this constructor will take the data from the Chinook Db (for demo purposes)
        public Person(string fn, string ln, DateTime dt, string remarks, string username, string pw)
        {
            this.UserName = username;
            this.Password = pw;
            this.FirstName = fn;
            this.LastName = ln;
            this.LastOrderDate = dt;
            this.Remarks = remarks;
        }


        public Person(Guid id, string fn, string ln, DateTime dt, string remarks, string username, string pw)
        {
            this.CustomerId = id;
            this.FirstName = fn;
            this.LastName = ln;
            this.LastOrderDate = dt;
            this.Remarks = remarks;
            this.UserName = username;
            this.Password = pw;
        }

        public Guid CustomerId { get; set; } = Guid.NewGuid();// when you create a property with a setter, C# creates a private backing variable of the same name for you. You don't see it.
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }// this is a "property"
        public string Remarks { get; set; }
        public DateTime LastOrderDate { get; set; }
        // [Range(0, 100)]
        // public int age { get; set; } = 0;// fields are not visible to swagger.

        // https://www.oreilly.com/library/view/regular-expressions-cookbook/9781449327453/ch04s01.html
        // [EmailAddress()]
        //[RegularExpression("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]// send in a specific regex pattern
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Got an error")]// The part before the @ restricts to characters commonly used in emails. The part after the @ restricts to characters allowed in domain names.
        public string Email { get; set; }

        //[RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        // public string Email2 { get; set; }

    }

}
