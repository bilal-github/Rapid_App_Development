using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class OrderDetailsDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        public static List<OrderDetails> GetOrdersDetails(int order_ID)
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            OrderDetails order;

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

                        orderDetails.Add(order);
                    }
                }
            }
            return orderDetails;
        }
    }
}
