using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class Bank
    {
       
        

        public static void PerformBankOperations()
        {
            Account? account = null;

            Console.WriteLine("Welcome to the Banking System!");

            // Display menu to create account
            Console.WriteLine("\nSelect Account Type:");
            Console.WriteLine("1. SavingsAccount");
            Console.WriteLine("2. CurrentAccount");

            Console.Write("Enter your choice (1 or 2): ");
            int accountChoice = Convert.ToInt32(Console.ReadLine());

            switch (accountChoice)
            {
                case 1:
                    // Create SavingsAccount object
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Interest Rate: ");
                    double interestRate = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Initial Balance: ");
                    double initialBalance = Convert.ToDouble(Console.ReadLine());

                    account = new SavingsAccount(accountNumber, interestRate, initialBalance );
                    break;

                case 2:
                    // Create CurrentAccount object
                    Console.Write("Enter Account Number: ");
                    int currentAccountNumber = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Initial Balance: ");
                    double currentInitialBalance = Convert.ToDouble(Console.ReadLine());

                    account = new CurrentAccount(currentAccountNumber, currentInitialBalance);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Exiting program.");
                    return;
            }

            
            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Calculate Interest (for SavingsAccount)");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Deposit
                        Console.Write("Enter the deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case 2:
                        // Withdraw
                        Console.Write("Enter the withdrawal amount: ");
                        double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                        account.Withdrawal(withdrawalAmount);
                        break;

                    case 3:
                        // Calculate Interest (for SavingsAccount)
                        if (account is SavingsAccount)
                        {
                            ((SavingsAccount)account).Calculate_Interest();
                        }
                        else
                        {
                            Console.WriteLine("Interest calculation is applicable only for SavingsAccount.");
                        }
                        break;

                    
                    case 4:
                        // Exit
                        Console.WriteLine("Exiting program. Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
