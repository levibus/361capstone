using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Identity;


namespace webpage
{
    public class CreateUserAccessor
    {  
        public Createuser(User user){
            String conn= "Server=localhost;Port=1433;Database=master;Trusted_Connection=True;Data Source=.\\SQLEXPRESS";
            try{
                conn.Open();
            }
            catch (Exception ex) {
                Console.WriteLine("Error - Could not open connection");
            }

            sqlQuery = "INSERT INTO  Customer(firstName, lastName, username, password) values (@firstName, @lastName, @username, @password)"
            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn)){
                
                cmd.Parameters.Add("@fistName", user.fistName);
                cmd.Parameters.Add("@lastName", user.lastName);
                cmd.Parameters.Add("@username", user.username);
                cmd.Parameters.Add("@password", user.password);

                //check if the amout was added
                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected > 0) {
                    Console.WriteLine("Rows Added");
                }
                else{
                    MessageBox.Show ("No Rows Added");
                }
            }
        }
    }
}
