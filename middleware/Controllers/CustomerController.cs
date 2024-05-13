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

        public JsonResult Get(string username, string password)  
        {
            string query = @"SELECT * FROM Customer WHERE username= @username AND password=@password;"; 
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

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Customer cust) 
        {
            string query = @"INSERT INTO  dbo.Customer (firstName, lastName, username, password) 
                             VALUES (@firstName, @lastName, @username, @password)";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ClothingStoreConnection");
            SqlDataReader myReader;
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
            return new JsonResult(cust.firstName);
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