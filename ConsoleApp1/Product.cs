using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product
    {
        public string productname { get; set; }

        public int productquantity { get; set; }

        public string productbrand { get; set; }

        public Product(string ProductName, int ProductQuantity, string ProductBrand)
        {
            productname = ProductName;
            productquantity = ProductQuantity;
            productbrand = ProductBrand;
        }
    }
}
