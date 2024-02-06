using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentTask1112.Model
{
    internal class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string phoneNumber;
        private string address;

        // Constructors
        public Customer()
        {
            // Default constructor
        }

        public Customer(int customerId, string firstName, string lastName, string emailAddress, string phoneNumber, string address)
        {
            // Overloaded constructor
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // Properties with validation
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if (IsValidEmail(value))
                    emailAddress = value;
                else
                    throw new ArgumentException("Invalid email address");
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (IsValidPhoneNumber(value))
                    phoneNumber = value;
                else
                    throw new ArgumentException("Invalid phone number");
            }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Validation methods
        private bool IsValidEmail(string email)
        {
            // Simple email validation using regular expression
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Simple 10-digit phone number validation
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        // Method to print all information
        public void PrintCustomerInformation()
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
