using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        public List<string> ProfitableInvoices { get; set; }
        public List<string> ExpensableInvoices { get; set; }
        public Reporting()
        {
            ProfitableInvoices = new List<string>();
            ExpensableInvoices = new List<string>();
        }
        public void GetProfitableInvoice(ProductInfo product)
        {
            string report = $"Name: {product.ProductName.Name}, quantity: {product.Quantity} arrived on {product.LastDeliveryDate}.";
            ProfitableInvoices.Add(report);
            Console.WriteLine(report);
        }
        public void GetAllProfitableInvoices()
        {
            foreach(var item in ProfitableInvoices)
            {
                Console.WriteLine(item);
            }
        }
        public void GetExpensableInvoice(ProductInfo product, int quantity)
        {
            string report = $"{quantity} {product.ProductName.Name} were sold. There are {product.Quantity} left.";
            ExpensableInvoices.Add(report);
            Console.WriteLine(report);
        }
        public void GetAllExpensableInvoices()
        {
            foreach (var item in ExpensableInvoices)
            {
                Console.WriteLine(item);
            }
        }
        public static void InventoryReport(Warehouse warehouse)
        {
            Console.WriteLine("Inventory Report:");
            foreach (var product in warehouse.Products.GroupBy(pr => pr.ProductName.Name))
            {
                Console.WriteLine($"{product.Key}: {product.Sum(pr => pr.Quantity)} in stock");
            }
        }
    }
}
