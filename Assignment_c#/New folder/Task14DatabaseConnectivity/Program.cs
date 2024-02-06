using Task14DatabaseConnectivity.Exception;
using Task14DatabaseConnectivity.Service;

namespace Task14DatabaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ICustomerService service = new CustomerService();
                IBankService bankService = new BankService();
                string choice;
                do
                {
                    Console.WriteLine("Welcome to the HM Bank");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("This are the Option:");
                    Console.WriteLine("1. Get Account Balance of Specific Account");
                    Console.WriteLine("2. To do Deposit in account");
                    Console.WriteLine("3. To do Withdraw from account");
                    Console.WriteLine("4. Transfer from one account to another account");
                    Console.WriteLine("5. Get account Detail");
                    Console.WriteLine("6. Get Transaction Detail");
                    Console.WriteLine("7. Create Account");
                    Console.WriteLine("8. List the Account");
                    Console.WriteLine("9. Exits");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Enter the Choice");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1": service.get_account_balance();
                            break;
                        case "2": service.Deposit();
                            break;
                        case "3": service.Withdraw();
                            break;
                        case "4": service.Transfer();
                            break;
                        case "5": service.GetAccountDetails();
                            break;
                        case "6": service.GetTransactions();
                            break;
                        case "7": bankService.Create_Account();
                            break;
                        case "8": bankService.ListAccount();
                            break;
                        case "9":
                            Console.WriteLine("Exiting the program");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again");
                            break;

                    }
                } while(choice != "9");

      
            }
            catch(NullPointerException npex)
            {
                Console.WriteLine(npex.Message);
            }

            
        }
    }
}
