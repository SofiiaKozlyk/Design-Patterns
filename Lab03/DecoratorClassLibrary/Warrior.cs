using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class Warrior : Hero
    {
        public Warrior(int protection, int attackDamage) : base("Warrior", protection, attackDamage)
        {
        }
    }
}
