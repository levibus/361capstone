using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Identity;

public class LoginAccessor
{
    public int accessLoginInformation(string username, string password)
    {
        object customerId = -1;
        string query = "SELECT * FROM dbo.Customer";
        //string query = "SELECT customerId FROM Customer WHERE username = @username AND password = @password";
        SqlConnection conn = new SqlConnection("Server=localhost;Port=1433;Database=master;Trusted_Connection=True;Data Source=.\\SQLEXPRESS"); // change to SQL server info
        using (SqlCommand command = new SqlCommand(query))
        {
            //command.Parameters.AddWithValue("@username", username);
            //command.Parameters.AddWithValue("@password", password);

            //command.Parameters.Add("@username", SqlDbType.VarChar);
            //command.Parameters["@username"].Value = username;
            //command.Parameters.Add("@password", SqlDbType.VarChar);
            //command.Parameters["@password"].Value = password;
            //try
            //{
                conn.Open();
            Console.WriteLine(conn.AccessToken.ToString());
                //customerId = command.ExecuteScalar();
                if (customerId != null)
                {
                }
                else
                {
                    customerId = 4;
                }

                conn.Close();
                return (int)customerId;
            //}
            //catch
            //{
                //return -2; // error in connection
            //}
        }
    }
}