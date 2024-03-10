using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductInfo : IDisplay
    {
        public Product ProductName { get; set; }
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity have to be more than 0");
                _quantity = value;
            }
        }
        public DateTime LastDeliveryDate { get; set; }
        public ProductInfo(Product product, int quantity, DateTime lastDeliveryDate)
        {
            ProductName = product;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {ProductName.Name}, quantity: {Quantity}, lastDeliveryDate: {LastDeliveryDate}");
        }
    }
}
