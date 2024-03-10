using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product : IDisplay
    {
        public string Name { get; set; }
        public string UnitOfMeasure { get; set; }
        public Money Price { get; set; }
        public Product(string name, string unitOfMeasure, Money price)
        {
            Name = name;
            UnitOfMeasure = unitOfMeasure;
            Price = price;
        }
        public void DecreasePrice(int coinsDiscount, int banknotesDiscount)
        {
            Price.RemoveMoney(banknotesDiscount, coinsDiscount);
        }
        public void IncreasePrice(int coins, int banknotes)
        {
            Price.AddMoney(banknotes, coins);
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, price for 1 {UnitOfMeasure}: {Price.Banknotes}.{Price.Coins:D2}");
        }
    }
}
