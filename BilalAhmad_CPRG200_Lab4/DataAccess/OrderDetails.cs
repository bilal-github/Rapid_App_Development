﻿/*
 * Author: Bilal Ahmad
 * Date: January 22, 2020
 * Purpose: Orderdetails properties class
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //public properties for orderdetails
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public Single Discount { get; set; }
    }
}