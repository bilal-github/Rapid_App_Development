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
        //Order order;
        int currentOrderListIndex = 0;
        bool updated = false;
        DateTime? nullDate;
        bool isNull = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateFields(btnBack, btnNext, currentOrderListIndex);
            dgvOrderDetails.Columns[2].DefaultCellStyle.Format = "c";
            dgvOrderDetails.Columns[4].DefaultCellStyle.Format = "p";
            dtpOrderDate.Enabled = false;
            dtpRequiredDate.Enabled = false;
            txtCustomerID.ReadOnly = true;

        }

        private void populateFields(Button disableButton, Button enableButton, int index)
        {

            orders = OrderDB.GetOrders();
            txtOrderID.Text = orders[index].OrderID.ToString();
            txtCustomerID.Text = orders[index].CustomerID;
            dtpOrderDate.Value = (DateTime)orders[index].OrderDate;
            dtpRequiredDate.Value = (DateTime)orders[index].RequiredDate;

            if (orders[index].ShippedDate != null)
            {
                dtpShippedDate.Format = DateTimePickerFormat.Long;
                dtpShippedDate.Value = (DateTime)orders[index].ShippedDate;
                isNull = false;
            }
            else
            {
                dtpShippedDate.CustomFormat = " ";
                dtpShippedDate.Format = DateTimePickerFormat.Custom;
                isNull = true;

            }


            List<OrderDetails> orderDetails_List = OrderDetailsDB.GetOrdersDetails(orders[index].OrderID);
            dgvOrderDetails.DataSource = orderDetails_List;

            txtTotalCharges.Text = CalculateCharges(orderDetails_List).ToString("c");

            Disablebuttion(disableButton, enableButton, index);
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
            int recordIndex;
            if(orders[currentOrderListIndex].ShippedDate != null){
                if((dtpShippedDate.Value != orders[currentOrderListIndex].ShippedDate))
                {
                    UpdateChanges(currentOrderListIndex, out updated);

                    if (updated == true)
                    {
                        recordIndex = currentOrderListIndex += 1;
                    }
                    else
                    {
                        recordIndex = currentOrderListIndex;
                    }
                }
                else
                {
                    recordIndex = currentOrderListIndex+=1;
                }
            }
            else
            {
                if(isNull != true)
                {
                    UpdateChanges(currentOrderListIndex, out updated);

                    if (updated == true)
                    {
                        recordIndex = currentOrderListIndex += 1;
                    }
                    else
                    {
                        recordIndex = currentOrderListIndex;
                    }
                }
                else
                {
                    recordIndex = currentOrderListIndex += 1; ;
                }
            }          
            populateFields(btnNext, btnBack, recordIndex);
            //dtpShippedDate.Format = DateTimePickerFormat.Long;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            int recordIndex;
            if (orders[currentOrderListIndex].ShippedDate != null)
            {
                if ((dtpShippedDate.Value != orders[currentOrderListIndex].ShippedDate))
                {
                    UpdateChanges(currentOrderListIndex, out updated);

                    if (updated == true)
                    {
                        recordIndex = currentOrderListIndex -= 1;
                    }
                    else
                    {
                        recordIndex = currentOrderListIndex;
                    }
                }
                else
                {
                    recordIndex = currentOrderListIndex -= 1;
                }
            }
            else
            {
                if (isNull != true)
                {
                    UpdateChanges(currentOrderListIndex, out updated);

                    if (updated == true)
                    {
                        recordIndex = currentOrderListIndex -= 1;
                    }
                    else
                    {
                        recordIndex = currentOrderListIndex;
                    }
                }
                else
                {
                    recordIndex = currentOrderListIndex -= 1; ;
                }
            }
            populateFields(btnBack, btnNext, recordIndex);
            //dtpShippedDate.Format = DateTimePickerFormat.Long;
        }

        private void Disablebuttion(Button disableButton, Button enableButton, int index)
        {
            if (index == orders.Count - 1 && disableButton == btnNext)
            {
                disableButton.Enabled = false;
            }
            else if (index == orders.IndexOf(orders[0]) && disableButton == btnBack)
            {
                disableButton.Enabled = false;
            }
            else
            {
                enableButton.Enabled = true;
            }
        }



        private void UpdateChanges(int index, out bool updated)
        {
            updated = false;

            if ((isNull == true))
            {
                //DialogResult result = MessageBox.Show("Would you like to save your changes", "Save Confirmation", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                //{
                    OrderDB.UpDateRecord(null,
                                        orders[index].OrderID,
                                        orders[index].CustomerID,
                                        (DateTime)orders[index].OrderDate,
                                        (DateTime)orders[index].RequiredDate);
                    updated = true;
                //}
            }


            else if (dtpShippedDate.Value > dtpOrderDate.Value && dtpShippedDate.Value < dtpRequiredDate.Value)
            {
                DialogResult result = MessageBox.Show("Would you like to save your changes", "Save Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    OrderDB.UpDateRecord(dtpShippedDate.Value,
                                        orders[index].OrderID,
                                        orders[index].CustomerID,
                                        (DateTime)orders[index].OrderDate,
                                        (DateTime)orders[index].RequiredDate);
                    updated = true;
                }
            }
            else
            {
                MessageBox.Show("Shipped Date must be between Order Date and Required Date");
                updated = false;
            }
        }

        private void dtpShippedDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                dtpShippedDate.CustomFormat = " ";
                isNull = true;
                dtpShippedDate.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}

