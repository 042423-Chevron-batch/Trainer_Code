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

        public Person(string fname, string lname, int age)
        {
            this.age = age;
            this.Fname = fname;
            this.Lname = lname;
        }

        // this constructor will take the data from the Chinook Db (for demo purposes)
        public Person(string username, string password, string fname, string lname, string email)
        {
            this.UserName = username;
            this.Password = password;
            this.Fname = fname;
            this.Lname = lname;
            this.Email = email;
        }

        public Guid PersonId { get; set; } = Guid.NewGuid();// when you create a property with a setter, C# creates a private backing variable of the same name for you. You don't see it.
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Fname { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Lname { get; set; }// this is a "property"

        [Range(0, 100)]
        public int age { get; set; } = 0;// fields are not visible to swagger.

        // https://www.oreilly.com/library/view/regular-expressions-cookbook/9781449327453/ch04s01.html
        [EmailAddress()]
        //[RegularExpression("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]// send in a specific regex pattern
        public string Email { get; set; }

        //[RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        [RegularExpression(@"^[A-Z0-9+_.-]+@[A-Z0-9.-]+$", ErrorMessage = "Got an error")]// The part before the @ restricts to characters commonly used in emails. The part after the @ restricts to characters allowed in domain names.
        public string Email2 { get; set; }

    }

}
