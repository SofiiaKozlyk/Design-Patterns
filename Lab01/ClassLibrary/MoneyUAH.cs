using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MoneyUAH : Money
    {
        public MoneyUAH(int banknotes, int coins) : base(banknotes, coins, "UAH")
        { 
        }
    }
}
