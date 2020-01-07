using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        public int Suppliers { get; set; }
        public int Category { get; set; }
        public int StoreLocation { get; set; }
        public string ProductsDescription { get; set; }
        public int UnitsInStock { get; set; }
        public float UnitPrice { get; set; }
        public float Discount { get; set; }
        public float FinalPrice { get; set; }
        public string AvaibleSize { get; set; }
        public string AvaibleColours { get; set; }
        public DateTime EntryDate { get; set; }
    }
}

