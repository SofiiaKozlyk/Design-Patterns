using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MoneyEUR : Money
    {
        public MoneyEUR(int banknotes, int coins) : base(banknotes, coins, "EUR")
        {
        }
    }
}
