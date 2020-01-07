using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class UnitsPerSize
    {
        public int UnitsPerSizeId { get; set; }
        public int ProductsId { get; set; }
        public int UnitsPerSizeInStock { get; set; }
        public int Size { get; set; }
        public string Colour { get; set; }

    }
}


