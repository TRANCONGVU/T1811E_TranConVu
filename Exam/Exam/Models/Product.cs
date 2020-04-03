using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int  UnitStock { get; set; }
        public bool UnitOnOrder { get; set; }
        public int ReOrderLever { get; set; }
        public bool Discontuned { get; set; }

        public Category Category { get; set; }
        

    }
}