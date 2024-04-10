using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Identity;

internal class LoginAccessor
{
    public int accessLoginInformation(string username, string password)
    {
        object customerId = -1;
        string query = "SELECT customerId FROM Customers WHERE username = @username AND password = @password";
        try
        {
            SqlConnection conn = new SqlConnection("Data Source = .\\SQLEXPRESS; Integrated Security = true"); // change to SQL server info
            conn.Open();
            Console.WriteLine("Connection Successful");

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@username", username, "@password", password);
                customerId = command.ExecuteScalar();

                if (customerId != null)
                {
                    Console.WriteLine("Login Information Found");
                }
                else
                {
                    Console.WriteLine("Login Information Invalid");
                    return -1;
                }
            }
            conn.Close();
            return (int)customerId;
        }
        catch
        {
            return -2; // error in connection
        }
    }
}