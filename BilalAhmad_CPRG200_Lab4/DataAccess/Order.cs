/*
 * Author: Bilal Ahmad
 * Date: January 22, 2020
 * Purpose: Order properties class
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //public properties for Order
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        //nullable datetimes
        public DateTime? RequiredDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
