using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class Sword : InventoryDecorator
    {
        public Sword(Hero hero) : base(hero)
        {
            this.AttackDamage += 100;
        }
    }
}
