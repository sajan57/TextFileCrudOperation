using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class ProductDetails
    {

        private List<Product> productitem = new List<Product>();
        private void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"Product: {product.productname}: {product.productquantity}:{product.productbrand}");
        }

        public void AddProduct(Product product)
        {
            productitem.Add(product);
        }

        public void DisplayAllProduct()
        {
            foreach (var product in productitem)
            {
                DisplayProductDetails(product);
            }
        }
        public void DeleteProduct(Product product)
        {
            productitem.Remove(product);
        }

        public void DeleteMatchingProduct(string searchPhrase, string searchDigit, int searchId)
        {
            var matchingProduct = productitem.Where(p => p.productname == searchPhrase && p.productbrand == searchDigit && p.productquantity == searchId).ToList();
            foreach (var contact in matchingProduct)
            {
                DeleteProduct(contact);
            }
        }


        public void update(string searchDigits, string updatedProductName, int updatedProductQuantity, string updatedProductBrand)
        {
            var matchingProduct = productitem.Where(p => p.productname == searchDigits).FirstOrDefault();
            matchingProduct.productname = updatedProductName;
            matchingProduct.productquantity = updatedProductQuantity;
            matchingProduct.productbrand = updatedProductBrand;
        }



    }
}
