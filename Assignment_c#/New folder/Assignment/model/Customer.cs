using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        //default constructor
        public Customer()
        {

        }
        //overloaded constructor
        public Customer(int customerId, string firstName, string lastName, string emailAddress, string phoneNumber, string address)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public void DesplayDetails()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Email Address: {EmailAddress}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Address: {Address}");
        }

    }
}
