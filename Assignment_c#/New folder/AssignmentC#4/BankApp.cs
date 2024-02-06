using AssignmentTask1112.Exception;
using AssignmentTask1112.Model;
using AssignmentTask1112.Repository;
using AssignmentTask1112.Service;
using System.Collections;
using System.Collections.ObjectModel;

namespace AssignmentTask1112
{
    internal class BankApp
    {
        static BankService bankService;
        static void Main(string[] args)
        {
            Collection<Account> accounts = new Collection<Account>();
            try {

                bankService = new BankService(new CustomerRepo(), accounts, "Main Branch", "New Delhi");

                bool exitRequested = false;

                do
                {
                    Console.WriteLine("\nBanking System Menu:");
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Get Balance");
                    Console.WriteLine("5. Transfer");
                    Console.WriteLine("6. Get Account Details");
                    Console.WriteLine("7. List Accounts");
                    Console.WriteLine("8. Exit");

                    Console.Write("\nEnter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice.ToLower())
                    {
                        case "1":
                        case "create_account":
                            CreateAccountSubMenu();
                            break;

                        case "2":
                        case "deposit":
                            PerformDeposit();
                            break;

                        case "3":
                        case "withdraw":
                            PerformWithdraw();
                            break;

                        case "4":
                        case "get_balance":
                            GetBalance();
                            break;

                        case "5":
                        case "transfer":
                            PerformTransfer();
                            break;

                        case "6":
                        case "getaccountdetails":
                            GetAccountDetails();
                            break;

                        case "7":
                        case "listaccounts":
                            ListAccounts();
                            break;

                        case "8":
                        case "exit":
                            exitRequested = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }

                } while (!exitRequested);
            }
            catch (InsufficientFundException ex)
            {
                Console.WriteLine($"Insufficient Fund Exception: {ex.Message}");
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine($"Invalid Account Exception: {ex.Message}");
            }
            catch (OverDraftLimitExcededException ex)
            {
                Console.WriteLine($"Overdraft Limit Exceeded Exception: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
        }

        static void CreateAccountSubMenu()
            {
             

                Console.WriteLine("\nCreate Account Menu:");
                Console.WriteLine("1. Savings Account");
                Console.WriteLine("2. Current Account");
                Console.WriteLine("3. Zero Balance Account");
                Console.WriteLine("4. Back to Main Menu");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateAccount("Savings");
                        break;

                    case "2":
                        CreateAccount("Current");
                        break;

                    case "3":
                        CreateAccount("ZeroBalance");
                        break;

                    case "4":
                        // Return to main menu
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        CreateAccountSubMenu();
                        break;
                }
            
        }

            static void CreateAccount(string accountType)
            {
            try { 
                Console.Write("Enter customer ID: ");
                int customerId = int.Parse(Console.ReadLine());

                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter email address: ");
                string emailAddress = Console.ReadLine();

                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Enter address: ");
                string address = Console.ReadLine();

                Customer customer = new Customer(customerId, firstName, lastName, emailAddress, phoneNumber, address);

                Console.Write("Enter initial balance: ");
                decimal initialBalance = decimal.Parse(Console.ReadLine());


                bankService.CreateAccount(customer, accountType, initialBalance);
                Console.WriteLine("Account created successfully.");
            }
            catch (InsufficientFundException ex)
            {
                Console.WriteLine($"Insufficient Fund Exception: {ex.Message}");
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine($"Invalid Account Exception: {ex.Message}");
            }
            catch (OverDraftLimitExcededException ex)
            {
                Console.WriteLine($"Overdraft Limit Exceeded Exception: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }

        }

            static void PerformDeposit()
            {
            try {
                Collection<Account> accounts = bankService.ListAccounts();
                Console.Write("Enter account number: ");
                long accountNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter deposit amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());


                decimal newBalance = bankService.Deposit(accountNumber, amount, accounts);
                Console.WriteLine($"Deposit successful. New balance: {newBalance}");

            }
            catch (InsufficientFundException ex)
            {
                Console.WriteLine($"Insufficient Fund Exception: {ex.Message}");
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine($"Invalid Account Exception: {ex.Message}");
            }
            catch (OverDraftLimitExcededException ex)
            {
                Console.WriteLine($"Overdraft Limit Exceeded Exception: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
        }

            static void PerformWithdraw()
            {
            try {
                Collection<Account> accounts = bankService.ListAccounts();
                Console.Write("Enter account number: ");
                long accountNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter withdrawal amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());


                decimal newBalance = bankService.Withdraw(accountNumber, amount, accounts);
                Console.WriteLine($"Withdrawal successful. New balance: {newBalance:C}");

            }
            catch (InsufficientFundException ex)
            {
                Console.WriteLine($"Insufficient Fund Exception: {ex.Message}");
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine($"Invalid Account Exception: {ex.Message}");
            }
            catch (OverDraftLimitExcededException ex)
            {
                Console.WriteLine($"Overdraft Limit Exceeded Exception: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
        }

            static void GetBalance()
            {
            Collection<Account> accounts = bankService.ListAccounts();
            Console.Write("Enter account number: ");
                long accountNumber = long.Parse(Console.ReadLine());


                decimal balance = bankService.GetAccountBalance(accountNumber,accounts);
                Console.WriteLine($"Account balance: {balance:C}");

            }

            static void PerformTransfer()
            {
            try {
                Collection<Account> accounts = bankService.ListAccounts();
                Console.Write("Enter source account number: ");
                long fromAccountNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter destination account number: ");
                long toAccountNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter transfer amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());


                bankService.Transfer(fromAccountNumber, toAccountNumber, amount,accounts);
                Console.WriteLine("Transfer successful.");
            }
            catch (InsufficientFundException ex)
            {
                Console.WriteLine($"Insufficient Fund Exception: {ex.Message}");
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine($"Invalid Account Exception: {ex.Message}");
            }
            catch (OverDraftLimitExcededException ex)
            {
                Console.WriteLine($"Overdraft Limit Exceeded Exception: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
        }

            static void GetAccountDetails()
            {
            Collection<Account> accounts = bankService.ListAccounts();
            Console.Write("Enter account number: ");
                long accountNumber = long.Parse(Console.ReadLine());


                string accountDetails = bankService.GetAccountDetails(accountNumber,bankService.ListAccounts());
                Console.WriteLine(accountDetails);

            }

            static void ListAccounts()
            {
                Collection<Account> accounts = bankService.ListAccounts();
                Console.WriteLine("\nList of Accounts:");
                foreach (var account in accounts)
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, Account Type: {account.AccountType}, Balance: {account.AccountBalance:C}");
                }

            }
            

        

    }
}