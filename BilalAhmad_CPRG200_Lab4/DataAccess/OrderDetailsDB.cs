/*
 * Author: Bilal Ahmad
 * Date: January 22, 2020
 * Purpose: gets and updates the orderdetails in the database.
 * */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //executes query to return orderdetails
    public static class OrderDetailsDB
    {
        //returns a connection
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        //returns a list of orderdetails based on a given order ID
        public static List<OrderDetails> GetOrdersDetails(int order_ID)
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            OrderDetails order;

            //sqlconnection populates the orderdetails list using an order id
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                                "FROM [Order Details] " +
                                "WHERE OrderID = @OrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("OrderID", order_ID);

                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        order = new OrderDetails();
                        order.OrderID = (int)reader["OrderID"];
                        order.ProductID = (int)reader["ProductID"];
                        order.UnitPrice = (decimal)reader["UnitPrice"];
                        order.Quantity = (short)reader["Quantity"];
                        order.Discount = (Single)reader["Discount"];

                        orderDetails.Add(order);//adds the current OrderDetail object to the list of OrderDetails
                    }
                }
            }
            return orderDetails;//returns the orderdetails list
        }
    }
}
