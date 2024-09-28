using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Strategy.Sort.App.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Credit { get; set; }


        public User(int id, string firstName, string lastName, int credit)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Credit = credit;
        }

        public void DisplayUser()
        {
            Console.WriteLine($"Id:{Id} FirstName:{FirstName} LastName:{LastName} Credit:{Credit}");
        }
    }
}
