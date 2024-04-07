using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class Shield : InventoryDecorator
    {
        public Shield(Hero hero) : base(hero)
        {
            this.Protection += 100;
        }
    }
}
