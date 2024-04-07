using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class Palladin : Hero
    {
        public Palladin(int protection, int attackDamage) : base("Palladin", protection, attackDamage)
        {
        }
    }
}
