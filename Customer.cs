using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        public Customer(string firstName, string lastName, string phone, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phone;
            this.Email = email;
        }
    }
}
