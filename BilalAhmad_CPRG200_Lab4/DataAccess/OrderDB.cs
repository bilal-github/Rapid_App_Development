using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class OrderDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            Order order;
            try
            {

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
                            order.RequiredDate = (DateTime)reader["RequiredDate"];
                            order.OrderDate = (DateTime)reader["OrderDate"];
                            order.ShippedDate = (DateTime)reader["ShippedDate"];

                            orders.Add(order);
                        }
                    }
                }
            }catch (Exception ex)
            {
                
            }
            return orders;
        }
        public static List<Order> GetOrderIDs()
        {
            List<Order> orders = new List<Order>();
            Order order;
            try
            {

                using (SqlConnection connection = GetConnection())
                {
                    string query = "SELECT OrderID " +
                                    "FROM Orders";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                        while (reader.Read())
                        {
                            order = new Order();
                            order.OrderID = (int)reader["OrderID"];                           

                            orders.Add(order);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return orders;
        }//to populate ComboBox

        public static Order ReturnOrder(int order_ID)
        {
            Order order = null;
            //int? order_ID = Convert.ToInt32(((KeyValuePair)((ComboBox)c).SelectedItem).Value);
            //int order_ID = Convert.ToInt32(order.OrderID);


            using (SqlConnection connection = OrderDB.GetConnection())
            {
                string query = "SELECT orderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                                "FROM orders " +
                                "WHERE orderID = @OrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("OrderID", order_ID);

                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    while (reader.Read())
                    {
                        order = new Order();
                        order.OrderID = Convert.ToInt32(reader["OrderID"]);
                        order.CustomerID = reader["CustomerID"].ToString();
                        order.OrderDate = (DateTime)reader["OrderDate"];
                        order.RequiredDate = (DateTime)reader["RequiredDate"];
                        order.ShippedDate = (DateTime)reader["ShippedDate"];
                    }
                }
            }         

            return order;
        }

        public static void UpDateRecord(DateTime shippedDate, int order_ID, string CustomerID, DateTime OrderDate, DateTime RequiredDate)
        {
            List<Order> orders = new List<Order>();
            Order order;
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
                    command.Parameters.AddWithValue("ShippedDate", shippedDate);
                    command.Parameters.AddWithValue("OrderID", order_ID);
                    command.Parameters.AddWithValue("CustomerID", CustomerID);
                    command.Parameters.AddWithValue("OrderDate", OrderDate);
                    command.Parameters.AddWithValue("RequiredDate", RequiredDate);
                    command.ExecuteNonQuery();
                    /*
                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    while (reader.Read())
                    {
                        order = new Order();
                        order.OrderID = Convert.ToInt32(reader["OrderID"]);
                        order.CustomerID = reader["CustomerID"].ToString();
                        order.OrderDate = (DateTime)reader["OrderDate"];
                        order.RequiredDate = (DateTime)reader["RequiredDate"];
                        order.ShippedDate = (DateTime)reader["ShippedDate"];

                    }
                    */
                }
            }
        }
    }
}
