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
        string query = "SELECT customerId FROM Customer WHERE username = @username AND password = @password";

        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = "Server=DESKTOP-QEQG0AR;Database=master;Trusted_Connection=true";
            try
            {
                conn.Open();
            }
            catch 
            {
                return -2; // error in connection
            }

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                customerId = command.ExecuteScalar();
                if (customerId == null)
                {
                    customerId = -1; // customer not found
                }

            }
            conn.Close();
        }
        return (int)customerId;
    }
}

