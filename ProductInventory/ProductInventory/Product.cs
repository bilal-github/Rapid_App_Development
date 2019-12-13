using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    public class Product
    {
        //private data
        //do not declare private for auot-implemented properties
        //private string name; //because name doesn't have conditions
        private decimal price;
        private int qty;


        //public properties
        //public string Name // accessor for the name because name is private
        //{
        //    get { return name; }
        //    set// set by other class when called
        //    {

        //        name = value; // use the value provided when property is used
        //    }
        //}

        // same as above Name property
        public string Name { get; set; }


        public decimal Price
        {
            get { return price; }
            set
            {
                // if provided value is negative, make it zero
                price = (value < 0) ? -value : value; // terenary operator, if value is less than 0, make it zero otherwise equals value
            }
        }
        public int Qty //using the method instead
        {
            get { return qty; }
            set
            {
                qty = (value < 0) ? -value : value;

            }
        }


        // constructors
        //if you do not provide a constructor, compiler supplies a default constructor ( no parameters)

        public Product() { } // default constructor
        public Product(string n, decimal p, int q) // constructor with parameters
        {
            Name = n;
            Price = p;
            Qty = q;
        }




        //public operations

        public decimal InventoryValue()
        {
            return price * qty;
        }

        public override string ToString()
        {
            return Name + ": " + price.ToString("c") + ", " + qty.ToString();
        }

        //method for writing CSV file
        public string ToCSV()
        {
            return Name + "," + price.ToString() + "," + qty.ToString();
        }
    }
}
