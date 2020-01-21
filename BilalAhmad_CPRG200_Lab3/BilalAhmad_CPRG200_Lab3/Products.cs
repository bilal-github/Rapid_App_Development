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

namespace BilalAhmad_CPRG200_Lab3
{
    public partial class Products : Form
    {
        //bool addButtonClicked = false;
        public Products()
        {
            InitializeComponent();
        }


        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Another user modified data, table needs to be updated", "Concurrency Exception");

                //refresh dataset
                Form1_Load(sender, e);
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, "No NULL Allowed Exception");
                //refresh dataset
                Form1_Load(sender, e);
            }
            catch (SqlException ex) // any error from ADO.NET provider
            {
                string[] fields = (ex.Message.ToString()).Split(' ');
                if (fields[1].Equals("INSERT"))
                {
                    MessageBox.Show("Please put in proper values when adding a new record", "SQL INSERT Error");
                }
                else if (fields[1].Equals("DELETE"))
                {
                    MessageBox.Show("Can't Delete a record which has ties to another table", "SQL DELETE Error");
                }
                else if (fields[1].Equals("UPDATE"))
                {
                    MessageBox.Show("Please put in proper values when updating a value", "SQL DELETE Error");
                }
                else
                {
                    MessageBox.Show("Database error while saving: " + ex.Message, "Unanticipated SQL Error");
                }

                //refresh dataset
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error while saving: " + ex.Message, e.GetType().ToString());
                //refresh dataset
                Form1_Load(sender, e);
            }
            finally
            {
                bindingNavigatorAddNewItem.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'northwindDataSet.Categories' table. You can move, or remove it, as needed.
                this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
                // TODO: This line of code loads data into the 'northwindDataSet.Suppliers' table. You can move, or remove it, as needed.
                this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
                // TODO: This line of code loads data into the 'northwindDataSet.Order_Details' table. You can move, or remove it, as needed.
                this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
                // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            }
            catch (SqlException ex) // any error from ADO.NET provider
            {
                MessageBox.Show("Database error while loading Data: " + ex.Message, e.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error while loading data: " + ex.Message, e.GetType().ToString());
            }
        }

        private void unitPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(unitPriceTextBox.Text, out int val))
            {
                if (Convert.ToInt32(unitPriceTextBox.Text) < 0)
                {
                    MessageBox.Show("UnitPrice must be a positive numeric", "Format Exception");
                    unitPriceTextBox.SelectAll();
                    unitPriceTextBox.Focus();
                }
            }
            else if (!Int32.TryParse(unitPriceTextBox.Text, out int val1))
            {
                MessageBox.Show("UnitPrice must be a numeric", "Format Exception");
                unitPriceTextBox.SelectAll();
                unitPriceTextBox.Focus();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        
                bindingNavigatorAddNewItem.Enabled = false;
            

        }
    }
}
