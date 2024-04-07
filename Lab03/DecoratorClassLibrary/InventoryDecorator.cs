using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class InventoryDecorator : Hero
    {
        public InventoryDecorator(Hero hero) : base(hero.Name, hero.Protection, hero.AttackDamage)
        {

        }
    }
}
