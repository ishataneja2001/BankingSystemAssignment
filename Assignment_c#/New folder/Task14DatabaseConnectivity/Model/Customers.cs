using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Model
{
    internal class Customers
    {
        public int CustomerId { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        // Constructor
        public Customers(int customerId, string firstName, string lastName, DateTime dateOfBirth, string email, int phoneNumber, string address)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // Default Constructor
        public Customers()
        {
            // Default constructor with no parameters
        }
        public override string ToString()
        {
            return $"CustomerId: {CustomerId}\t FirstName: {FirstName}\t LastName: {LastName}\t DateOfBirth: {DateOfBirth}\t Email: {Email}\t PhoneNumber: {PhoneNumber}\t Address: {Address}";
        }
    }
}
