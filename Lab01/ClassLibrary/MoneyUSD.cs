using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MoneyUSD : Money
    {
        public MoneyUSD(int banknotes, int coins) : base(banknotes, coins, "USD")
        {
        }
    }
}
