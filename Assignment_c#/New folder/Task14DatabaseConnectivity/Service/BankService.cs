using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14DatabaseConnectivity.Model;
using Task14DatabaseConnectivity.Repository;

namespace Task14DatabaseConnectivity.Service
{
    internal class BankService : IBankService
    {
        readonly IBankRepo _bankService;
        public BankService()
        {
            _bankService = new BankRepo();
        }

        public void Create_Account()
        {
            Customers customers = new Customers();
            Console.WriteLine("Enter the Existing CustomerID:: ");
            customers.CustomerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Account type::");
            string account_type = Console.ReadLine();
            Console.WriteLine("Enter the Initial Balance::");
            float balance = float.Parse(Console.ReadLine());
            try
            {
                bool addAccountStatus = _bankService.Create_Account(customers, account_type, balance);
                if (addAccountStatus)
                {
                    Console.WriteLine("Account Created Successful");
                }
                else
                {
                    Console.WriteLine("FAILED!!! Account Create unsuccessful");
                }
            }catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListAccount()
        {
            Console.WriteLine("List of Accounts::");
            try
            {
                List<Accounts> getListAccount = _bankService.ListAccounts();
                if (getListAccount.Any())
                {
                    foreach (Accounts obj in getListAccount)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No record found");
                }
            
            }catch(IOException ex) 
            { 
                Console.WriteLine(ex.Message);
            }

        }

    }
 }

