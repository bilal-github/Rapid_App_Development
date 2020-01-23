/*
 * Author: Bilal Ahmad
 * Date: January 22, 2020
 * Purpose: This class returns and updates the database for orders
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
    //runs all queries for the orderdb
    public static class OrderDB
    {
        //returns connection
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        //returns a list of order objects
        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            Order order;
            try
            {
                //sqlconnection populates a list of orders from the Northwind Database
                using (SqlConnection connection = GetConnection())
                {
                    string query = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                                    "FROM Orders";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                        while (reader.Read())
                        {
                            order = new Order();
                            order.OrderID = (int)reader["OrderID"];
                            order.CustomerID = reader["CustomerID"].ToString();
                            if (reader["RequiredDate"] == DBNull.Value)
                            {
                                order.RequiredDate = null;
                            }
                            else
                            {
                                order.RequiredDate = Convert.ToDateTime(reader["RequiredDate"]);
                            }
                            if (reader["OrderDate"] == DBNull.Value)
                            {
                                order.OrderDate = null;
                            }
                            else
                            {
                                order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                            }
                            if (reader["ShippedDate"] == DBNull.Value)
                            {
                                order.ShippedDate = null;
                            }
                            else
                            {
                                order.ShippedDate = Convert.ToDateTime(reader["ShippedDate"]);
                            }

                            orders.Add(order); //adds the current order object to the list of orders
                        }
                    }
                }
            }
            catch (Exception ex) //exceptions
            {
                throw ex;
            }
            return orders;//returns the list of orders
        }
    
        //updates a record based on optimistic parameters
        public static void UpDateRecord(DateTime? shippedDate, int order_ID, string CustomerID, DateTime? OrderDate, DateTime? RequiredDate)
        {
            List<Order> orders = new List<Order>();
            Order order;
            try
            {
                //sqlconnection updates a record
                using (SqlConnection connection = OrderDB.GetConnection())
                {
                    string updateQuery = "UPDATE ORDERS SET ShippedDate = @ShippedDate " +
                                        "WHERE OrderID = @OrderID " +
                                            "AND CustomerID = @CustomerID " +
                                            "AND OrderDate = @OrderDate " +
                                            "AND RequiredDate = @RequiredDate";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        connection.Open();
                        if (shippedDate == null)
                        {
                            command.Parameters.AddWithValue("ShippedDate", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("ShippedDate", shippedDate);
                        }

                        command.Parameters.AddWithValue("OrderID", order_ID);
                        command.Parameters.AddWithValue("CustomerID", CustomerID);
                        command.Parameters.AddWithValue("OrderDate", OrderDate);
                        command.Parameters.AddWithValue("RequiredDate", RequiredDate);
                        command.ExecuteNonQuery();

                    }
                }
            }catch (Exception ex)//exception
            {
                throw ex;
            }
        }
    }
}
