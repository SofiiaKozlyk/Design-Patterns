using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class Mage : Hero
    {
        public Mage(int protection, int attackDamage) : base("Mage", protection, attackDamage)
        {
        }
    }
}
