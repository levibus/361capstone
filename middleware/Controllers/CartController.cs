﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using _361capstone.Models;

namespace _361capstone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public CartController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get(Cart cart) 
        {
            string query = @"SELECT * FROM Cart WHERE customerId = @customerId;"; 

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ClothingStoreConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@customerId", cart.customerId);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Cart cart) 
        {
            string query = @"IF EXISTS (SELECT * FROM Cart WHERE customerId = @customerId AND SKU = @SKU)
            BEGIN
                UPDATE Cart SET Quantity = Quantity + @Quantity WHERE customerId = @customerId AND SKU = @SKU;
            END
            ELSE
            BEGIN
                INSERT INTO Cart (customerId, SKU, Quantity) VALUES (@customerId, @SKU, @Quantity); 
            END;";

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
                        myCommand.Parameters.AddWithValue("@customerId", cart.customerId);
                        myCommand.Parameters.AddWithValue("@SKU", cart.SKU);
                        myCommand.Parameters.AddWithValue("@Quantity", cart.Quantity);
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

            return new JsonResult(cart.customerId);
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(Cart cart)
        {
            string query = "DELETE FROM Cart WHERE customerId = @customerId AND SKU = @SKU;";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ClothingStoreConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@customerId", cart.customerId);
                    myCommand.Parameters.AddWithValue("@SKU", cart.SKU);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }


    }
}