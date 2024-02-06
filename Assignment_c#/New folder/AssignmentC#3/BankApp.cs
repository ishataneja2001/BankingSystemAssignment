using AssignmentTask10.Repository;
using AssignmentTask10.Model;
namespace AssignmentTask10
{
    internal class BankApp
    {
        static void Main(string[] args)
        {
            //TASK 10 Has a Relation/Association
            /*   Create a `Customer` class with the following attributes:
                • Customer ID
                • First Name
                • Last Name
                • Email Address (validate with valid email address)
                • Phone Number (Validate 10-digit phone number)
                • Address
                • Methods and Constructor:
             o Implement default constructors and overload the constructor with Account 
                    attributes, generate getter, setter, print all information of attribute) methods for 
                    the attributes*/

            /*   Create an `Account` class with the following attributes:
                    • Account Number (a unique identifier).
                    • Account Type (e.g., Savings, Current)
                    • Account Balance
                    • Customer (the customer who owns the account)
                    • Methods and Constructor:
                o Implement default constructors and overload the constructor with Account 
                    attributes, generate getter, setter, (print all information of attribute) methods for 
                    the attributes.*/

            /*Ques 1 Create a Bank Class and must have following requirements:
                1. Create a Bank class to represent the banking system. It should have the following methods:
                    • create_account(Customer customer, long accNo, String accType, float balance): Create 
                        a new bank account for the given customer with the initial balance.
                    • get_account_balance(account_number: long): Retrieve the balance of an account given 
                        its account number. should return the current balance of account.
                    • deposit(account_number: long, amount: float): Deposit the specified amount into the 
                        account. Should return the current balance of account.
                    • withdraw(account_number: long, amount: float): Withdraw the specified amount from 
                        the account. Should return the current balance of account.
                    • transfer(from_account_number: long, to_account_number: int, amount: float): 
                        Transfer money from one account to another.
                    • getAccountDetails(account_number: long): Should return the account and customer 
                        details
            
             2. Ensure that account numbers are automatically generated when an account is created, starting 
                from 1001 and incrementing for each new account
            
             3. Create a BankApp class with a main method to simulate the banking system. Allow the user to 
                interact with the system by entering commands such as "create_account", "deposit", 
                "withdraw", "get_balance", "transfer", "getAccountDetails" and "exit." create_account should 
                display sub menu to choose type of accounts and repeat this operation until user exit.*/


            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("\n===== Banking System =====");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Get Balance");
                Console.WriteLine("5. Transfer");
                Console.WriteLine("6. Get Account Details");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice (1-7): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateAccountSubMenu(bank);
                        break;
                    case "2":
                        PerformDeposit(bank);
                        break;
                    case "3":
                        PerformWithdraw(bank);
                        break;
                    case "4":
                        CheckBalance(bank);
                        break;
                    case "5":
                        PerformTransfer(bank);
                        break;
                    case "6":
                        GetAccountDetails(bank);
                        break;
                    case "7":
                        Console.WriteLine("Exiting the Banking System. Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void CreateAccountSubMenu(Bank bank)
        {
            Console.WriteLine("\n===== Create Account =====");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Current Account");
            Console.WriteLine("3. Go back to main menu");

            Console.Write("Enter your choice (1-3): ");
            string accountChoice = Console.ReadLine();

            switch (accountChoice)
            {
                case "1":
                    CreateAccount(bank, "Savings");
                    break;
                case "2":
                    CreateAccount(bank, "Current");
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }

        static void CreateAccount(Bank bank, string accountType)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your email address: ");
            string emailAddress = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Console.Write("Enter the initial balance: ");
            decimal initialBalance;
            while (!decimal.TryParse(Console.ReadLine(), out initialBalance))
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal value for initial balance.");
            }

            Customer customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber,
                Address = address
            };

            bank.CreateAccount(customer, accountType, initialBalance);
        }

        static void PerformDeposit(Bank bank)
        {
            Console.Write("Enter your account number: ");
            long accountNumber;
            while (!long.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid long value for account number.");
            }

            Console.Write("Enter the deposit amount: ");
            decimal depositAmount;
            while (!decimal.TryParse(Console.ReadLine(), out depositAmount))
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal value for deposit amount.");
            }

            bank.Deposit(accountNumber, depositAmount);
        }

        static void PerformWithdraw(Bank bank)
        {
            Console.Write("Enter your account number: ");
            long accountNumber;
            while (!long.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid long value for account number.");
            }

            Console.Write("Enter the withdrawal amount: ");
            decimal withdrawalAmount;
            while (!decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal value for withdrawal amount.");
            }

            bank.Withdraw(accountNumber, withdrawalAmount);
        }

        static void CheckBalance(Bank bank)
        {
            Console.Write("Enter your account number: ");
            long accountNumber;
            while (!long.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid long value for account number.");
            }

            decimal balance = bank.GetAccountBalance(accountNumber);

            if (balance >= 0)
            {
                Console.WriteLine($"Current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        static void PerformTransfer(Bank bank)
        {
            Console.Write("Enter your account number (from): ");
            long fromAccountNumber;
            while (!long.TryParse(Console.ReadLine(), out fromAccountNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid long value for account number.");
            }

            Console.Write("Enter the recipient's account number (to): ");
            long toAccountNumber;
            while (!long.TryParse(Console.ReadLine(), out toAccountNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid long value for recipient's account number.");
            }

            Console.Write("Enter the transfer amount: ");
            decimal transferAmount;
            while (!decimal.TryParse(Console.ReadLine(), out transferAmount))
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal value for transfer amount.");
            }

            bank.Transfer(fromAccountNumber, toAccountNumber, transferAmount);
        }

        static void GetAccountDetails(Bank bank)
        {
            Console.Write("Enter your account number: ");
            long accountNumber;
            while (!long.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid long value for account number.");
            }

            bank.GetAccountDetails(accountNumber);
        }
    }
 }

