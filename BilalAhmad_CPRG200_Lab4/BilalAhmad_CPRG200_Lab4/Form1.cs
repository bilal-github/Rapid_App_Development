/*
 * Author: Bilal Ahmad
 * Date: January 22, 2020
 * Purpose: Main form for the lab
 * */
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
        List<OrderDetails> orders_Details_List = new List<OrderDetails>(); //initializes an empty list
        List<Order> orders;//declares list of orders
        //Order order;
        int currentOrderListIndex = 0;//starting index
        bool updated = false; //keeps track if the record is updated
        bool isNull = false; //keeps track if shipped date is null
        public Form1()
        {
            InitializeComponent();
        }

        //loads initial state of all fields
        private void Form1_Load(object sender, EventArgs e)
        {
            populateFields(btnBack, btnNext, currentOrderListIndex);
            dgvOrderDetails.Columns[2].DefaultCellStyle.Format = "c";
            dgvOrderDetails.Columns[4].DefaultCellStyle.Format = "p";

            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            
            dgvOrderDetails.AutoResizeColumns();

            dtpOrderDate.Enabled = false;
            dtpRequiredDate.Enabled = false;
            txtCustomerID.ReadOnly = true;
            txtOrderID.ReadOnly = true;
            dgvOrderDetails.ReadOnly = true;
            txtTotalCharges.ReadOnly = true;

        }

        //called to refresh all the fields and datagridview
        private void populateFields(Button disableButton, Button enableButton, int index)
        {

            orders = OrderDB.GetOrders();
            txtOrderID.Text = orders[index].OrderID.ToString();
            txtCustomerID.Text = orders[index].CustomerID;
            dtpOrderDate.Value = (DateTime)orders[index].OrderDate;
            dtpRequiredDate.Value = (DateTime)orders[index].RequiredDate;

            if (orders[index].ShippedDate != null) // if the shippeddate is not null
            {
                dtpShippedDate.Format = DateTimePickerFormat.Long;
                dtpShippedDate.Value = (DateTime)orders[index].ShippedDate;
                isNull = false;
            }
            else //shipped date is null
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
        //calculates the total charge for current orderID
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
            return totalCharge;//returns total charge
        }

        /*goes to next order 
        * based on updated status, either current record is refreshed or moves to next record
        */
        private void btnNext_Click(object sender, EventArgs e)
        {
            int recordIndex;
            if (orders[currentOrderListIndex].ShippedDate != null)//not null in database
            {
                if ((dtpShippedDate.Value != orders[currentOrderListIndex].ShippedDate)) //value changed from initial
                {
                    UpdateChanges(currentOrderListIndex, out updated); //runs update

                    if (updated == true)
                    {
                        recordIndex = currentOrderListIndex += 1;
                    }
                    else
                    {
                        recordIndex = currentOrderListIndex;
                    }
                }
                else if (isNull == true) //value is now null
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
                else //hasn't changed
                {
                    recordIndex = currentOrderListIndex += 1;
                }
            }
            else //null in database
            {
                if (isNull != true) //not null now
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
                else //hasn't changed
                {
                    recordIndex = currentOrderListIndex += 1; ;
                }
            }
            populateFields(btnNext, btnBack, recordIndex);//refresh all the fields and datagridview
        }

        /*goes to previous order 
         * based on updated status, either current record is refreshed or moves to previous record
         */
        private void btnBack_Click(object sender, EventArgs e)
        {
            int recordIndex;
            if (orders[currentOrderListIndex].ShippedDate != null)//not null in database
            {
                if ((dtpShippedDate.Value != orders[currentOrderListIndex].ShippedDate)) // value has changed
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
                else // value hasn't changed
                {
                    recordIndex = currentOrderListIndex -= 1;
                }
            }
            else//empty in database
            {
                if (isNull != true) //not null now
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
                else // hasn't changed
                {
                    recordIndex = currentOrderListIndex -= 1; ;
                }
            }
            populateFields(btnBack, btnNext, recordIndex); //refreshes all the fields and datagridview
        }

        //disables button if the the current record is either first one or last one.
        private void Disablebuttion(Button disableButton, Button enableButton, int index)
        {
            if (index == orders.Count - 1 && disableButton == btnNext) // if last record, disable next button
            {
                disableButton.Enabled = false;
            }
            else if (index == orders.IndexOf(orders[0]) && disableButton == btnBack) // if first record, disable back button
            {
                disableButton.Enabled = false;
            }
            else //otherwise buttons are enabled
            {
                enableButton.Enabled = true;
            }
        }


        //updates the changes to the database
        private void UpdateChanges(int index, out bool updated)
        {
            updated = false;

            if ((isNull == true)) // if record is null
            {
                DialogResult result = MessageBox.Show("Would you like to save your changes", "Save Confirmation", MessageBoxButtons.YesNo);
                // if user selects yes, update the record in the database
                if (result == DialogResult.Yes) 
                {
                    OrderDB.UpDateRecord(null,
                                        orders[index].OrderID,
                                        orders[index].CustomerID,
                                        (DateTime)orders[index].OrderDate,
                                        (DateTime)orders[index].RequiredDate);
                    updated = true;
                }
            }

            //if value is between order date and required date
            else if (dtpShippedDate.Value > dtpOrderDate.Value && dtpShippedDate.Value < dtpRequiredDate.Value)
            {
                DialogResult result = MessageBox.Show("Would you like to save your changes", "Save Confirmation", MessageBoxButtons.YesNo);
                //if user selects yes, updates the record in the database
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
            //otherwise invalid date message is shown
            else
            {
                MessageBox.Show("Shipped Date must be between Order Date and Required Date");
                updated = false;
            }
        }

        /*if either backspace or delete is pressed in the shipped date field, clears the field
         * Changes the format of the datetimepicker to custom
         */
        private void dtpShippedDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                dtpShippedDate.CustomFormat = " ";
                isNull = true;
                dtpShippedDate.Format = DateTimePickerFormat.Custom;
            }
        }

        /*if the value was null first
         * changes the format of the datetimepicker to Long,
         */
        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {
            if (isNull == true)
            {
                dtpShippedDate.Format = DateTimePickerFormat.Long;
                isNull = false;
            }
        }        
    }
}

