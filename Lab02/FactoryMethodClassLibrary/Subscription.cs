using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethodClassLibrary
{
    public abstract class Subscription
    {
        public string Type { get; set; }
        public double MonthlyFee { get; set; }
        public int MinSubscriptionPeriod{ get; set; }
        public List<string> Сhannels { get; set; }
        public Subscription(string type, double monthlyFee, int minSubscriptionPeriod, List<string> сhannels)
        {
            Type = type;
            MonthlyFee = monthlyFee;
            MinSubscriptionPeriod = minSubscriptionPeriod;
            Сhannels = сhannels;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type}, Monthly Fee: {MonthlyFee}, " +
            $"Minimum SubscriptionPeriod: {MinSubscriptionPeriod}, Сhannels: ");
            foreach (var channel in Сhannels)
            {
                Console.WriteLine($"{channel}");
            }
        }
    }
}
