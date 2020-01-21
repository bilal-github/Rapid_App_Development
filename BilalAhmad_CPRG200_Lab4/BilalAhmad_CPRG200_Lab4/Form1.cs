using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilalAhmad_CPRG200_Lab4
{
    public partial class Form1 : Form
    {
        List<OrderDetails> orders_Details_List = new List<OrderDetails>();
        List<Order> orders;
        Order order;
        int currentOrderListIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadComboBox();
            cmbOrderID.Visible = false;
            populateFields(currentOrderListIndex);




        }

        private void populateFields(int index)
        {
            orders = OrderDB.GetOrders();
            txtOrderID.Text = orders[index].OrderID.ToString();
            txtCustomerID.Text = orders[index].CustomerID;
            txtOrderDate.Text = orders[index].OrderDate.ToString();
            txtRequiredDate.Text = orders[index].RequiredDate.ToString();
            //txtShippedDate.Text = orders[index].ShippedDate.ToString();
            dtpShippedDate.Value = orders[index].ShippedDate;

            List<OrderDetails> orderDetails_List = OrderDetailsDB.GetOrdersDetails(orders[index].OrderID);
            dgvOrderDetails.DataSource = orderDetails_List;
            txtTotalCharges.Text = CalculateCharges(orderDetails_List).ToString("c");
        }
        private decimal CalculateCharges(List<OrderDetails> orderDetails_List)
        {
            decimal totalCharge = 0;
            decimal unitPrice;
            int quantity;
            decimal Discount;


            foreach (OrderDetails order in orderDetails_List)
            {
                unitPrice = order.UnitPrice;
                quantity = order.Quantity;
                Discount = (decimal)order.Discount;

                totalCharge += unitPrice * (1 - Discount) * quantity;
            }
            return totalCharge;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            CheckForChanges(currentOrderListIndex);
            int nextRecord = currentOrderListIndex += 1;
            populateFields(nextRecord);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            int previousRecord = currentOrderListIndex -= 1;
            populateFields(previousRecord);
        }
        private void CheckForChanges(int index)
        {
            if (dtpShippedDate.Value != orders[index].ShippedDate)
            {
                DialogResult result = MessageBox.Show("Would you like to save your changes", "Save Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    OrderDB.UpDateRecord(dtpShippedDate.Value,
                                        orders[index].OrderID,
                                        orders[index].CustomerID,
                                        orders[index].OrderDate,
                                        orders[index].RequiredDate);
                }
            }
        }


    }
}
