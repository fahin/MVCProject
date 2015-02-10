using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MedicineOrder
    {
        public int MedicineOrderID { set; get; }
        public string Medicine { get; set; }
        public string Quantity { get; set; }
        public string Centre { get; set; }
    }

    public class MedicineTable
    {
        public List<MedicineOrder> MedicinesOrders { set; get; }

    }
}