using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14DatabaseConnectivity.Model;
using Task14DatabaseConnectivity.Utility;

namespace Task14DatabaseConnectivity.Repository
{
    internal class BankRepo : IBankRepo
    {
        public string connectionString;
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public BankRepo()
        {
            connectionString = DBConnection.GetConnectionString();
            cmd = new SqlCommand();
        }

        public bool Create_Account(Customers customers, string account_type, float balance)
        {
            using(SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into Accounts values(@customer_id,@account_type,@balance) ";
                cmd.Parameters.AddWithValue("@customer_id", customers.CustomerId);
                cmd.Parameters.AddWithValue("@account_type", account_type);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Connection = sqlConn;
                sqlConn.Open();
                int addaccount = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return addaccount == 0? false:true;


            }
        }

        public List<Accounts> ListAccounts()
        {
            List<Accounts> accounts = new List<Accounts>();
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                cmd.CommandText = "Select * from Accounts";
                cmd.Connection = sqlConn;
                sqlConn.Open ();
                cmd.Parameters.Clear();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int account_id = reader.GetInt32(reader.GetOrdinal("account_id"));
                        int customer_id = reader.GetInt32(reader.GetOrdinal("customer_id"));
                        string account_type = reader.GetString(reader.GetOrdinal("account_type"));
                        decimal balance = reader.GetDecimal(reader.GetOrdinal("balance"));
                        accounts.Add (new Accounts(account_id, customer_id, account_type, balance));
                    }


                }
                return accounts;
            }
        }
    }
}
