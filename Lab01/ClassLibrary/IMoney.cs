using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IMoney
    {
        public void AddMoney(int banknotes, int coins);
        public void RemoveMoney(int banknotes, int coins);
    }
}
