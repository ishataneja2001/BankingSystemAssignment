using Assignment.model;
using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 1 Banking system
            Condition statement 
            Tasks:
                1.Write a program that takes the customer's credit score and annual income as input.
                2.Use conditional statements(if-else) to determine if the customer is eligible for a loan.
                3.Display an appropriate message based on eligibility.*/


            //Console.Write("Enter your Credit score: ");
            //int creditScore = int.Parse(Console.ReadLine());
            //Console.Write("Enter your Annual income: ");
            //int annualIncome = int.Parse(Console.ReadLine());

            //if (creditScore > 700 && annualIncome >= 50000)
            //{
            //    Console.WriteLine(" Eligible");
            //}
            //else 
            //{
            //    Console.WriteLine("Not Eligible");
            //}

            /*Task 2: Nested Conditional Statements
                Create a program that simulates an ATM transaction.Display options such as "Check Balance,"
                "Withdraw," "Deposit,".Ask the user to enter their current balance and the amount they want to
                 withdraw or deposit. Implement checks to ensure that the withdrawal amount is not greater than the
                 available balance and that the withdrawal amount is in multiples of 100 or 500.Display appropriate
                 messages for success or failure.*/

            //Console.Write("Enter your Current Balance: ");
            //Double cur_balance = double.Parse(Console.ReadLine());
            //Option:
            //Console.WriteLine("1 Check Balance");
            //Console.WriteLine("2 Withdrawal");
            //Console.WriteLine("3 Deposit");
            //Console.Write("Enter your choice (1,2,3): ");

            //int choice = int.Parse(Console.ReadLine());
            //if (choice == 1)
            //{
            //    Console.WriteLine($" Your current balance is: {cur_balance}");
            //    goto Option;
            //}
            //else if (choice == 2)
            //{
            //    Console.Write("Enter the amount to Withdrawal: ");
            //    double wd_amount = double.Parse(Console.ReadLine());

            //    if (wd_amount > cur_balance)
            //    {
            //        Console.WriteLine("Insufficient Fund. Withdrawal failed");
            //        goto Option;
            //    }
            //    else if (wd_amount % 100 != 0 || wd_amount % 500 != 0)
            //    {
            //        Console.WriteLine("Withdrawal amount must be in multiples of 100 or 500. Withdrawal failed.");
            //        goto Option;
            //    }
            //    else
            //    {
            //        cur_balance -= wd_amount;
            //        Console.WriteLine($"Successful Withdrawal. Now Current Balance is: {cur_balance} ");
            //        goto Option;
            //    }
            //}
            //else if (choice == 3)
            //{
            //    Console.Write("Enter the amount to Deposit: ");
            //    double dp_amount = double.Parse(Console.ReadLine());
            //    cur_balance += dp_amount;
            //    Console.WriteLine($"Deposit Successfull. Now Current Balance is: {cur_balance} ");
            //    goto Option;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice. Please choice the valid option");
            //    goto Option;
            //}

            /*Task 3: Loop Structures
                      You are responsible for calculating compound interest on savings accounts for bank customers. You
                      need to calculate the future balance for each customer's savings account after a certain number of years.
                Tasks:
                    1.Create a program that calculates the future balance of a savings account.
                    2.Use a loop structure(e.g., for loop) to calculate the balance for multiple customers.
                    3.Prompt the user to enter the initial balance, annual interest rate, and the number of years.
                    4.Calculate the future balance using the formula: 
                        future_balance = initial_balance * (1 + annual_interest_rate / 100) ^ years.
                    5.Display the future balance for each customer.*/

            //Console.Write("Enter the number of Customer: ");
            //int numCustomer = int.Parse(Console.ReadLine());

            //for (int index = 1; index <= numCustomer; index++)
            //{

            //    Console.Write("Enter your Initial balance: ");
            //    double initialBalance = double.Parse(Console.ReadLine());

            //    Console.Write("Enter your Annual interest rate: "); ;
            //    double annualInterestRate = double.Parse(Console.ReadLine());

            //    Console.Write("Enter the Number of year: ");
            //    int numYear = int.Parse(Console.ReadLine());

            //    Double futureBalance = initialBalance * Math.Pow(1 + annualInterestRate / 100,numYear);

            //    Console.WriteLine($"The future balance for customer: {futureBalance}");
            //}

            /*Task 4: Looping, Array and Data Validation
                      You are tasked with creating a program that allows bank customers to check their account balances. 
                      The program should handle multiple customer accounts, and the customer should be able to enter their
                      account number, balance to check the balance.
                Tasks:
                    1.Create a Python program that simulates a bank with multiple customer accounts.
                    2.Use a loop(e.g., while loop) to repeatedly ask the user for their account number and
                        balance until they enter a valid account number.
                    3.Validate the account number entered by the user.
                    4.If the account number is valid, display the account balance.If not, ask the user to try again.*/

            //int[] accountDetail = {1234,2222,4444,3333 };
            //double[] accountBalance = {20000,10000,40000,50000 };

            //while (true)
            //{
            //    Console.WriteLine("Enter your Account number: ");
            //    int accountNum = int.Parse(Console.ReadLine());

            //    int index = Array.IndexOf(accountDetail, accountNum);

            //    if (index != -1) 
            //    {
            //        double balance = accountBalance[index];
            //        Console.WriteLine($"Balance of the account {accountNum} is {balance}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid account number. Please try again");
            //    }
            //}
            /*Task 5: Password Validation
                    Write a program that prompts the user to create a password for their bank account.Implement if
                    conditions to validate the password according to these rules:
                    • The password must be at least 8 characters long.
                    • It must contain at least one uppercase letter.
                    • It must contain at least one digit.
                    • Display appropriate messages to indicate whether their password is valid or not.*/
            //    Console.WriteLine("Create a password for your bank account:");

            //    string password = Console.ReadLine();

            //    if (IsPasswordValid(password))
            //    {
            //        Console.WriteLine("Password is valid. Your bank account is now secured!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid password. Please follow the password requirements.");
            //    }



            //static bool IsPasswordValid(string password)
            //{

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("Password must be at least 8 characters long.");
            //        return false;
            //    }


            //    if (!ContainsUppercaseLetter(password))
            //    {
            //        Console.WriteLine("Password must contain at least one uppercase letter.");
            //        return false;
            //    }


            //    if (!ContainsDigit(password))
            //    {
            //        Console.WriteLine("Password must contain at least one digit.");
            //        return false;
            //    }


            //    return true;
            //}


            //static bool ContainsUppercaseLetter(string password)
            //{
            //    foreach (char character in password)
            //    {
            //        if (char.IsUpper(character))
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}

            //static bool ContainsDigit(string password)
            //{
            //    foreach (char character in password)
            //    {
            //        if (char.IsDigit(character))
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}
            /*Task 6: Maintain Transaction
                    Create a program that maintains a list of bank transactions(deposits and withdrawals) for a customer. 
                    Use a while loop to allow the user to keep adding transactions until they choose to exit.Display the
                    transaction history upon exit using looping statements.*/

            //string[] transactionHistory = new string[10];
            //Console.WriteLine("Welcome to the Bank");
            //int transactionCount = 0;

            //while (true)
            //{
            //    Console.WriteLine("Press 1 Deposit\nPress 2 Withdrawal\nPress 3 Exit");

            //    Console.Write("Enter any one option: ");
            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter the Amount to deposit: ");
            //            double amountDeposit = double.Parse(Console.ReadLine());
            //            transactionHistory[transactionCount++] = ($"Desposit Amount: {amountDeposit}");
            //            break;
            //        case 2:
            //            Console.Write("Enter the Amount to Withdrawal: ");
            //            double amountWithdrawal = double.Parse(Console.ReadLine());
            //            transactionHistory[transactionCount++] = ($"Withdrawal Amount: {amountWithdrawal}");
            //            break;
            //        case 3:
            //            Console.WriteLine("Transation History");

            //            foreach(string amount in transactionHistory)
            //            {
            //                 Console.WriteLine(amount);
            //            }
            //            return;
            //        default:
            //            Console.WriteLine("Invalid choice. Please try again");
            //            break;
            //    }
            //}

            //---------------OOPS,Collection and Exception Handling------------------
            //Task 7 Class and Object
            /*1.Create a `Customer` class with the following confidential attributes:
            • Attributes
                o Customer ID
                o First Name
                o Last Name
                o Email Address
                o Phone Number
                o Address
            • Constructor and Methods
                o Implement default constructors and overload the constructor with Customer
                    attributes, generate getter and setter, (print all information of attribute) methods for 
                    the attributes.*/

            //Customer customer = new Customer(1,"Isha","Taneja","itaneja318@gmail.com","12345","Delhi");
            //customer.DesplayDetails();

            //Customer customer1 = new Customer();
            //customer1.CustomerId = 2;
            //customer1.FirstName = "Keshav";
            //customer1.LastName = "Taneja";
            //customer1.EmailAddress = "keshav123@gmail.com";
            //customer1.PhoneNumber = "11111";
            //customer1.Address = "haryana";
            //customer1.DesplayDetails();

            /*Create an `Account` class with the following confidential attributes:
             • Attributes
                 o Account Number
                 o Account Type(e.g., Savings, Current)
                 o Account Balance
             • Constructor and Methods
                 o Implement default constructors and overload the constructor with Account
                     attributes,
                 o Generate getter and setter, (print all information of attribute) methods for the
                     attributes.
                 o Add methods to the `Account` class to allow deposits and withdrawals.
                     - deposit(amount: float): Deposit the specified amount into the account.
                         withdraw(amount: float): Withdraw the specified amount from the account.
                         withdraw amount only if there is sufficient fund else display insufficient
                         balance.
                     - calculate_interest() : method for calculating interest amount for the available
                         balance.interest rate is fixed to 4.5 %
             • Create a Bank class to represent the banking system.Perform the following operation in
                 main method:
                 o create object for account class by calling parameter constructor.
                 o deposit(amount: float): Deposit the specified amount into the account.
                 o withdraw(amount: float): Withdraw the specified amount from the account.
                 o calculate_interest(): Calculate and add interest to the account balance for savings
                     accounts.*/
            //Account account = new Account(1234, "Savings", 1000.0);
            //account.Deposit(500);
            //account.Withdrawal(200);
            //account.Calculate_Interest();

            //Task 8 Inheritance and polymorphism
            /*1.Overload the deposit and withdraw methods in Account class as mentioned below.
                • deposit(amount: float): Deposit the specified amount into the account.
                • withdraw(amount: float) : Withdraw the specified amount from the account.withdraw
                    amount only if there is sufficient fund else display insufficient balance.
                • deposit(amount: int) : Deposit the specified amount into the account.
                • withdraw(amount: int) : Withdraw the specified amount from the account.withdraw
                    amount only if there is sufficient fund else display insufficient balance.
                • deposit(amount: double) : Deposit the specified amount into the account.
                • withdraw(amount: double) : Withdraw the specified amount from the account.withdraw
                    amount only if there is sufficient fund else display insufficient balance.*/

            //Account account = new Account(123456, "Savings", 1000.0);

            // Deposit using different data types
            //account.Deposit(500.0);
            //account.Deposit(200);
            //account.Deposit(100.75);


            // Withdraw using different data types
            //account.Withdrawal(300.0);
            //account.Withdrawal(150);
            //account.Withdrawal(200.50);

            //account.Calculate_Interest();
            // Print the final account information

            //account.DisplayAccountDetails();

            /*2.Create Subclasses for Specific Account Types
    • Create subclasses for specific account types(e.g., `SavingsAccount`, `CurrentAccount`)
    that inherit from the `Account` class.
    o SavingsAccount: A savings account that includes an additional attribute for 
    interest rate. override the calculate_interest() from Account class method to
    calculate interest based on the balance and interest rate.
    o CurrentAccount: A current account that includes an additional attribute
    overdraftLimit.A current account with no interest. Implement the withdraw()
    method to allow overdraft up to a certain limit (configure a constant for the
    overdraft limit).*/

            //SavingsAccount svAccount = new SavingsAccount(12133,0.045,2000);
            //CurrentAccount cuAccount = new CurrentAccount(12342,2000);

            //svAccount.Deposit(500.0);
            //svAccount.Calculate_Interest();
            //svAccount.Withdrawal(200.0);

            //// Deposit and withdraw from the CurrentAccount
            //cuAccount.Deposit(200.0);
            //cuAccount.Withdrawal(700.0); 

            //// Print the final account information
            //svAccount.DisplayAccountDetails();
            //cuAccount.DisplayAccountDetails();

            /*3. Create a Bank class to represent the banking system.perform this in class ,dont do in main method
                 • Display menu for user to create object for account class by calling parameter
                     constructor.Menu should display options `SavingsAccount` and `CurrentAccount`. user
                     can choose any one option to create account.use switch case for implementation.
                 • deposit(amount: float) : Deposit the specified amount into the account.
                 • withdraw(amount: float) : Withdraw the specified amount from the account.For saving
                     account withdraw amount only if there is sufficient fund else display insufficient balance.
                     For Current Account withdraw limit can exceed the available balance and should not
                     exceed the overdraft limit.
                 • calculate_interest() : Calculate and add interest to the account balance for savings
                     accounts.*/

            //Bank.PerformBankOperations();





        }

    }
}
