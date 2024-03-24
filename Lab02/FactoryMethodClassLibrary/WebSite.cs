using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodClassLibrary
{
    public class WebSite : IBuySubscription
    {
        public Subscription BuySubscription()
        {
            return new DomesticSubscription();
        }
    }
}
