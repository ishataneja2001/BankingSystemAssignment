using Task14DatabaseConnectivity.Model;
using Task14DatabaseConnectivity.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Collections.ObjectModel;


namespace Task14DatabaseConnectivity.Repository
{
    internal class CustomerRepo : ICustomerRepo
    {
        public string connectionString;
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public CustomerRepo()
        {
            connectionString = DBConnection.GetConnectionString();
            cmd = new SqlCommand();
        }



        public double get_account_balance(long account_id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "Select balance from Accounts where account_id = @account_id";
                cmd.Parameters.AddWithValue("@account_id", account_id);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.Parameters.Clear();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    
                    double balance = reader.GetDouble(reader.GetOrdinal("balance"));

                    return balance;

                }
            }
        }
        public double Deposit(long account_id, float amount)
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "update Accounts set balance = balance + @amount where account_id = @account_id";
                
                cmd.Parameters.AddWithValue("@account_id", account_id);
                cmd.Parameters.AddWithValue("@amount", amount);
                
                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = " Select balance from Accounts where account_id = @acc_id";
                cmd.Parameters.AddWithValue("@acc_id", account_id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    double balance = (double)reader.GetDecimal(reader.GetOrdinal("balance"));
                    return balance;

                }
            }
        }

        public decimal Withdraw(long account_id, float amount)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = " Select balance,account_type from Accounts where account_id = @account_id ";
                cmd.Parameters.AddWithValue("@account_id", account_id);
                cmd.Connection = sqlConnection;

                sqlConnection.Open();
                decimal balance;
                string accountType;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    
                    balance = reader.GetDecimal(reader.GetOrdinal("balance"));
                    accountType = reader.GetString(reader.GetOrdinal("account_type"));

                }
                SavingsAccount savAcc = new SavingsAccount(balance);

                
                if (accountType.Equals("savings") && (!savAcc.IsminBalance(amount)))
                {
                    Console.WriteLine("Trasaction FAILED!!!");
                    return balance;
                }
                CurrentAccount currAcc = new CurrentAccount(balance);
                if(accountType.Equals("current") && (!currAcc.OverDraftLimit(amount)))
                {
                    Console.WriteLine("Transaction FAILED!!! Overpass the Limit");
                    return balance;
                }
                cmd.CommandText = "update Accounts set balance = balance - @amount where account_id = @account_id";
                cmd.Parameters.AddWithValue("@amount", amount);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                return balance-(decimal)amount;
                

            }
        }
        public bool Transfer(long from_acc_id, long to_acc_id, float amount)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                
            {
                //double fromAccountBalance = get_account_balance(from_acc_id);
                //double toAccountBalance = get_account_balance(to_acc_id);
                cmd.CommandText = "UPDATE Accounts SET balance = balance - @amount WHERE account_id = @from_acc_id";

                cmd.Parameters.AddWithValue("@from_acc_id", from_acc_id);
                

                cmd.Parameters.AddWithValue("@amount", amount);

                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = " UPDATE Accounts SET balance = balance + @amount WHERE account_id = @to_acc_id ";

                cmd.Parameters.AddWithValue("@to_acc_id", to_acc_id);
                

                int transfer = cmd.ExecuteNonQuery();

                    
                return transfer == 0 ? false : true;
            }
            

        }


        public Collection<object> GetAccountDetails(long acc_id)
        {
            Collection<object> obj = new Collection<object>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {




                cmd.CommandText = " Select C.*,A.* from Customers C join Accounts A on C.customers_id = A.customer_id where account_id = @acc_id ";
                cmd.Parameters.AddWithValue("@acc_id", acc_id);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.Parameters.Clear();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    
                        //string account_type = reader.GetString(reader.GetOrdinal("account_type"));
                        int customer_id = reader.GetInt32(reader.GetOrdinal("customer_id"));
                        string first_name = reader.GetString(reader.GetOrdinal("first_name"));
                        string last_name = reader.GetString(reader.GetOrdinal("last_name"));
                        DateTime DOB = reader.GetDateTime(reader.GetOrdinal("DOB"));
                        string email = reader.GetString(reader.GetOrdinal("email"));
                        int phone_number = reader.GetInt32(reader.GetOrdinal("phone_number"));
                        string address = reader.GetString(reader.GetOrdinal("address"));

                    Customers customer = new Customers(customer_id,first_name,last_name, DOB, email,phone_number,address);

                        int account_id = reader.GetInt32(reader.GetOrdinal("account_id"));
                        string account_type = reader.GetString(reader.GetOrdinal("account_type"));
                        decimal balance = reader.GetDecimal(reader.GetOrdinal("balance"));
                        //obj.Add(new Customers(customer_id, first_name, last_name, DOB, email, phone_number, address));
                    Accounts accounts = new Accounts(account_id,customer_id , account_type, balance);
                    obj.Add(customer);
                    obj.Add(accounts);


                }
                return obj;

            }
        }
        public List<Transactions> GetTransactions( DateTime startDate, DateTime endDate)
        {
            List<Transactions> transactions = new List<Transactions>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                cmd.CommandText = "Select * from Transactions Where transaction_date between @startDate and @endDate";

                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);



                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.Parameters.Clear();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        int transaction_id = reader.GetInt32(reader.GetOrdinal("transaction_id"));
                        int account_id = reader.GetInt32(reader.GetOrdinal("account_id"));
                        
                        string transation_type = reader.GetString(reader.GetOrdinal("transaction_type"));
                        decimal amount = reader.GetDecimal(reader.GetOrdinal("amount"));
                        DateTime transaction_date = reader.GetDateTime(reader.GetOrdinal("transaction_date"));


                        transactions.Add(new Transactions(transaction_id, account_id, transation_type, amount, transaction_date));
                        ;
                    }
                }
                return transactions;
            }
        }

        
    }
}
