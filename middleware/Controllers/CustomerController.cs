using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using _361capstone.Models;
using System.Reflection.Metadata;
using System.Text.Json;

namespace _361capstone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get(string username, string password)  // string username, string password
        {
            string query = @"SELECT * FROM Customer WHERE username= @username AND password=@password;"; //WHERE username= @username AND password=@password"; //
            CurrentUser currentUser = new CurrentUser();
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ClothingStoreConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@username", username);
                    myCommand.Parameters.AddWithValue("@password", password);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            if (table.Rows.Count != 0)
            {
                //List<CurrentUser> user = datatable2list.ConvertDataTableToList<CurrentUser>(table);
                currentUser.customerId = (int)table.Rows[0][0];
                //currentUser.firstName = (string)table.Rows[1][0];
                //currentUser.lastName = (string)table.Rows[2][0];
                //currentUser.username = (string)table.Rows[3][0];
                //currentUser.password = (string)table.Rows[4][0];
                //currentUser.addressId = (int)table.Rows[5][0];
                //currentUser.cardNumber = (string)table.Rows[6][0];
                //currentUser.cardExp = (string)table.Rows[7][0];
                //currentUser.cardCVC = (int)table.Rows[8][0];
                //currentUser.cartId = (int)table.Rows[9][0];
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Customer cust) // string firstName, string lastName, string username, string password
        {
            string query = @"INSERT INTO  dbo.Customer (firstName, lastName, username, password) VALUES (@firstName, @lastName, @username, @password)";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ClothingStoreConnection");
            SqlDataReader myReader;
            string test = "test";
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    try
                    {
                        myCommand.Parameters.AddWithValue("@firstName", cust.firstName);
                        myCommand.Parameters.AddWithValue("@lastName", cust.lastName);
                        myCommand.Parameters.AddWithValue("@username", cust.username);
                        myCommand.Parameters.AddWithValue("@password", cust.password);
                        myReader = myCommand.ExecuteReader();
                        test = "test2";
                        table.Load(myReader);
                        myReader.Close();
                        myCon.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }

                }
            }

            return new JsonResult(test);
        }

        //[HttpPut] // IMPLEMENT IF TIME, BUT NOT VERY IMPORTANT
        //public JsonResult Put(int customerId, string firstName)
        //{
        //    string query = "UPDATE Customer SET firstName= @firstName WHERE customerId=@customerId";

        //    DataTable table = new DataTable();
        //    string sqlDataSource = _configuration.GetConnectionString("ClothingStoreConnection");
        //    SqlDataReader myReader;
        //    using (SqlConnection myCon = new SqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //        {
        //            myCommand.Parameters.AddWithValue("@customerId", customerId);
        //            myCommand.Parameters.AddWithValue("@firstName", firstName);
        //            myReader = myCommand.ExecuteReader();
        //            table.Load(myReader);
        //            myReader.Close();
        //            myCon.Close();
        //        }
        //    }

        //    return new JsonResult("Updated Successfully");
        //}

        //[HttpDelete("{id}")]
        //public JsonResult Delete(int customerId)
        //{
        //    string query = "DELETE FROM Customer WHERE customerId=@customerId";

        //    DataTable table = new DataTable();
        //    string sqlDataSource = _configuration.GetConnectionString("ClothingStoreConnection");
        //    SqlDataReader myReader;
        //    using (SqlConnection myCon = new SqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //        {
        //            myCommand.Parameters.AddWithValue("@customerId", customerId);

        //            myReader = myCommand.ExecuteReader();
        //            table.Load(myReader);
        //            myReader.Close();
        //            myCon.Close();
        //        }
        //    }

        //    return new JsonResult("Deleted Successfully");
        //}


    }
    }