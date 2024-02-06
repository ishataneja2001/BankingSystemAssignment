using AssignmentC_2.Model;

namespace AssignmentC_2
{
    public  class Bank
    {
        static void Main(string[] args)
        {
            //Task 9 Abstraction
            /* 1. Create an abstract class BankAccount that represents a generic bank account. It should include 
                    the following attributes and methods:
                • Attributes:
                    o Account number.
                    o Customer name.
                    o Balance.
                • Constructors:
                    o Implement default constructors and overload the constructor with Account 
                        attributes, generate getter and setter, print all information of attribute methods 
                        for the attributes.
                • Abstract methods:
                    o deposit(amount: float): Deposit the specified amount into the account.*/


            /*Ques2 Create two concrete classes that inherit from BankAccount:
                • SavingsAccount: A savings account that includes an additional attribute for interest rate. 
                    Implement the calculate_interest() method to calculate interest based on the balance 
                    and interest rate.
                • CurrentAccount: A current account with no interest. Implement the withdraw() method 
                    to allow overdraft up to a certain limit (configure a constant for the overdraft limit).*/




            /*Ques3  Create a Bank class to represent the banking system. Perform the following operation in main 
                    method:
                • Display menu for user to create object for account class by calling parameter 
                    constructor. Menu should display options `SavingsAccount` and `CurrentAccount`. user 
                   can choose any one option to create account. use switch case for implementation.
                    create_account should display sub menu to choose type of accounts.
                o Hint: Account acc = new SavingsAccount(); or Account acc = new 
                    CurrentAccount();
                • deposit(amount: float): Deposit the specified amount into the account.*/

        //    Console.WriteLine("Welcome to the Bank System!");

        //    BankAccount acc = null;

        //    Console.WriteLine("Choose an account type:");
        //    Console.WriteLine("1. Savings Account");
        //    Console.WriteLine("2. Current Account");

        //    int accountTypeChoice = int.Parse(Console.ReadLine());

        //    switch (accountTypeChoice)
        //    {
        //        case 1:
        //            acc = CreateAccount("Savings Account");
        //            break;
        //        case 2:
        //            acc = CreateAccount("Current Account");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice. Exiting...");
        //            return;
        //    }

        //    while (true)
        //    {
        //        Console.WriteLine("\nChoose an operation:");
        //        Console.WriteLine("1. Deposit");
        //        Console.WriteLine("2. Withdraw");
        //        Console.WriteLine("3. Display Account Information");
        //        Console.WriteLine("4. Calculate Interest (for Savings Account)");
        //        Console.WriteLine("5. Exit");

        //        int choice = int.Parse(Console.ReadLine());

        //        switch (choice)
        //        {
        //            case 1:
        //                Console.Write("Enter the deposit amount: ");
        //                decimal depositAmount = decimal.Parse(Console.ReadLine());
        //                acc.Deposit(depositAmount);
        //                break;
        //            case 2:
        //                Console.Write("Enter the withdrawal amount: ");
        //                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
        //                acc.Withdraw(withdrawalAmount);
        //                break;
        //            case 3:
        //                acc.DisplayAccountInfo();
        //                break;
        //            case 4:
        //                if (acc is SavingsAccount)
        //                {
        //                    ((SavingsAccount)acc).CalculateInterest();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Interest calculation is only applicable for Savings Account.");
        //                }
        //                break;
        //            case 5:
        //                Console.WriteLine("Exiting...");
        //                return;
        //            default:
        //                Console.WriteLine("Invalid choice. Please choose a valid option.");
        //                break;
        //        }
        //    }
        //}

        //static BankAccount CreateAccount(string accountType)
        //{
        //    Console.WriteLine($"Creating a new {accountType}");

        //    Console.Write("Enter Account Number: ");
        //    string accountNumber = Console.ReadLine();

        //    Console.Write("Enter Customer Name: ");
        //    string customerName = Console.ReadLine();

        //    Console.Write("Enter Initial Balance: ");
        //    decimal initialBalance = decimal.Parse(Console.ReadLine());

        //    if (accountType.Equals("Savings Account", StringComparison.OrdinalIgnoreCase))
        //    {
                
        //        return new SavingsAccount(accountNumber, customerName, initialBalance);
        //    }
        //    else if (accountType.Equals("Current Account", StringComparison.OrdinalIgnoreCase))
        //    {
        //        return new CurrentAccount(accountNumber, customerName, initialBalance);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid account type. Exiting...");
        //        return null;
        //    }
        

        
    }
    }
}
