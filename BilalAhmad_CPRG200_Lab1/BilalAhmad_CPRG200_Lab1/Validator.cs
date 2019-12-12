using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for MessageBox

namespace BilalAhmad_CPRG200_Lab1
{
    //repository of validation methods
    public static class Validator
    {
        public static bool IsPresent(TextBox tb, string name)
        {
            bool valid = true; // tb has input
            if (tb.Text == "")
            {
                valid = false;
                MessageBox.Show(name + " is required", "Input Error");
                tb.Focus();
            }

            return valid;
        }//ends IsPresent method

        public static bool IsInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;

            if(!Int32.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        public static bool IsNonNegativeInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;

            if (!Int32.TryParse(tb.Text, out val)) //not int32
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // negative
            {
                valid = false;
                MessageBox.Show(name + " Must be positive or zero");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        public static bool IsDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;

            if (!Double.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        

        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool valid = true;
            double val;

            if (!Double.TryParse(tb.Text, out val)) // not a double
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // negative
            {
                valid = false;
                MessageBox.Show(name + " Must be positive or zero");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }

        public static bool IsDecimal(TextBox tb, string name)
        {
            bool valid = true;
            decimal val;

            if (!Decimal.TryParse(tb.Text, out val))
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool valid = true;
            decimal val;

            if (!Decimal.TryParse(tb.Text, out val)) // not a double
            {
                valid = false;
                MessageBox.Show(name + " must be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // negative
            {
                valid = false;
                MessageBox.Show(name + " Must be positive or zero");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
    }//ends class
}//ends namespace
