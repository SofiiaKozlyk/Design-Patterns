using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodClassLibrary
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base("Premium", 20.75, 9, new List<string> { "PremiumChannel1", "Channel2", "PremiumChannel3", "PremiumChannel4" })
        {
        }
    }
}
