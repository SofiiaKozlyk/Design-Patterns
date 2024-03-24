using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodClassLibrary
{
    public class ManagerCall : IBuySubscription
    {
        public Subscription BuySubscription()
        {
            return new PremiumSubscription();
        }
    }
}
