using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse : IDisplay
    {
        public List<ProductInfo> Products { get; set; }
        public Reporting Reporting { get; set; }
        public Warehouse(List<ProductInfo> products)
        {
            Reporting = new Reporting();
            Products = new List<ProductInfo>();
            foreach(ProductInfo product in products)
            {
                AddProduct(product);
            }
        }
        public Warehouse(ProductInfo product)
        {
            Reporting = new Reporting();
            Products = new List<ProductInfo>();
            AddProduct(product);
        }
        public void AddProduct(ProductInfo product)
        {
            Products.Add(product);
            Reporting.GetProfitableInvoice(product);
        }
        public void RemoveProduct(string searchName, int quantity)
        {
            ProductInfo foundProduct = Products.Find(product => String.Equals(product.ProductName.Name, searchName, StringComparison.OrdinalIgnoreCase));
            if(foundProduct != null)
            {
                if(foundProduct.Quantity >= quantity)
                {
                    foundProduct.Quantity -= quantity;
                    Reporting.GetExpensableInvoice(foundProduct, quantity);
                }
                else
                {
                    Console.WriteLine("Insufficient amount!");
                }
                if(foundProduct.Quantity == 0)
                {
                    Products.Remove(foundProduct);
                }
            }
        }
        public void Display()
        {
            foreach(var product in Products)
            {
                product.Display();
            }
        }
    }
}
