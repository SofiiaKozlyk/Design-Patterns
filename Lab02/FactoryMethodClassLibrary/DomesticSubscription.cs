using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodClassLibrary
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base("Domestic", 51.5, 5, new List<string> { "Channel1", "Channel2" })
        {
        }
    }
}
