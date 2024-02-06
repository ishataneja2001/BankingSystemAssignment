using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Task14DatabaseConnectivity.Exception;
using Task14DatabaseConnectivity.Model;
using Task14DatabaseConnectivity.Repository;

namespace Task14DatabaseConnectivity.Service
{
    internal class CustomerService : ICustomerService
    {
        readonly ICustomerRepo _customerService;
        public CustomerService()
        {
            _customerService = new CustomerRepo();
        }
        public void get_account_balance()
        {
            Console.WriteLine("Enter AccountID::");
            long account_id = long.Parse(Console.ReadLine());

            try
            {
                double getAccountBalance = _customerService.get_account_balance(account_id);
                if (getAccountBalance.Equals(null))
                {

                    Console.WriteLine("No record found" );

                }
                else
                {
                    Console.WriteLine(getAccountBalance);
                }
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Deposit()
        {
            Console.WriteLine("Enter AccountID::");
            long account_id = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount to be Deposit::");
            float amount = float.Parse(Console.ReadLine());
            
            try
            {
                double amountToDeposit = _customerService.Deposit(account_id, amount);
                if (amountToDeposit.Equals(null))
                {

                    Console.WriteLine("No record found");

                }
                else
                {
                    Console.WriteLine(amountToDeposit);
                }
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter AccountID::");
            long account_id = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount to be Withdraw::");
            float amount = float.Parse(Console.ReadLine());

            try
            {
                decimal amountToWithdraw = _customerService.Withdraw(account_id, amount);
                if (amountToWithdraw.Equals(null))
                {

                    Console.WriteLine("No record found");

                }
                else
                {
                    Console.WriteLine(amountToWithdraw);
                }
            }
            catch (InsufficientFundException Ifex)
            {
                Console.WriteLine(Ifex.Message);
            }
            catch (InvalidAccountException Iaex)
            {
                Console.WriteLine(Iaex.Message);
            }
            catch(OverDraftLimitExcededException Odex)
            {
                Console.WriteLine(Odex.Message);
            }
        }

        public void Transfer()
        {
            Console.WriteLine("Enter AccountID from which Amount to Transfer::");
            long from_acc_id = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter AccountID to which Amount to Received::");
            long to_acc_id = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount to Transfer::");
            float amount = float.Parse(Console.ReadLine());
            try
            {
                bool Transfer = _customerService.Transfer(from_acc_id,to_acc_id,amount);
                if (Transfer==true)
                {
                    Console.WriteLine("Transfer Amount Successfull ");
                }
                else
                {
                    Console.WriteLine("Failed!!Transfer Amount unsuccessfull");
                }
            }
            catch (InsufficientFundException Ifex)
            {
                Console.WriteLine(Ifex.Message);
            }
            catch(InvalidAccountException Iaex)
            {
                Console.WriteLine(Iaex.Message);
            }
        }

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter AccountID::");
            long acc_id = long.Parse(Console.ReadLine());

            try
            {
                Collection<object> GetAccountDetail = _customerService.GetAccountDetails(acc_id);
                if (GetAccountDetail.Any())
                {
                    foreach (object obj in GetAccountDetail)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No record found");
                }
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void GetTransactions()
        {
            Console.WriteLine("Enter StartDate to Get the List of Transactions::");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter EndDate to Get the List of Transactions");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            try
            {
                List<Transactions> GetTransactions = _customerService.GetTransactions(startDate, endDate);
                if (GetTransactions.Any())
                {
                    foreach (Transactions obj in GetTransactions)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No record found");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
