using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
   public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductsId { get; set; }
        public int UnitsPerSizeId { get; set; }
        public string ProductsName { get; set; }
        public int Category { get; set; }
        public int Suppliers { get; set; }
        public int StoreLocation { get; set; }
        public int UnitsSold { get; set; }
        public DateTime SoldDate { get; set; }
        public float UnitPrice { get; set; }
        public float Discount { get; set; }
        public float FinalPrice { get; set; }
        public int Size { get; set; }
        public string Colour { get; set; }





    }
}

