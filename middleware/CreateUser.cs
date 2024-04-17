using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Identity;
using System.Collections;


namespace webpage
{
    public class CreateUserAccessor
    {  
       public int Createuser(User user){ //user class doesn't exist right now
            object customerId = -1;
            using (SqlConnection conn  = new SqlConnection()){
                conn.ConnectionString = "Server=DESKTOP-QEQG0AR;Database=master;Trusted_Connection=True";
                try{
                    conn.Open();
                }
                catch (Exception ex) {
                    Console.WriteLine("Error - Could not open connection");
                }

                string sqlInsert = "INSERT INTO  Customer(firstName, lastName, username, password) values (@firstName, @lastName, @username, @password)";
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conn)) {

                    cmd.Parameters.Add("@fistName", user.fistName);
                    cmd.Parameters.Add("@lastName", user.lastName);
                    cmd.Parameters.Add("@username", user.username);
                    cmd.Parameters.Add("@password", user.password);

                    //check if the amout was added
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        Console.WriteLine("Rows Added");
                    }
                    else {
                        Console.WriteLine("No Rows Added");
                    }

                    string sqlGetCustomerId = "SELECT customerId FROM Customer WHERE username = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(sqlGetCustomerId, conn))
                    {
                        command.Parameters.AddWithValue("@username", user.username); 
                        command.Parameters.AddWithValue("@password", user.password);

                        customerId = command.ExecuteScalar();
                        if (customerId == null)
                        {
                            customerId = -1; // customer not found
                        }

                    }


                }
                conn.Close();
            }
            return (int)customerId;
        }
    }
}
