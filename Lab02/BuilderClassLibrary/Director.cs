using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class Director
    {
        public Hero CreateHero(IHeroBuilder heroBuilder)
        {
            return heroBuilder
                    .SetName("Hero")
                    .SetHeight(170)
                    .SetBuild("Muscular")
                    .SetHairColor("Black")
                    .SetEyeColor("Green")
                    .SetOutfit("Armor")
                    .AddInventoryItem("Sword")
                    .AddInventoryItem("Shield")
                    .AddInventoryItem("Spear")
                    .GetHero();
        }
        public Enemy CreateEnemy(IEnemyBuilder enemyBuilder)
        {
            return enemyBuilder
                    .SetName("Enemy")
                    .SetClass("A")
                    .SetLevel(5)
                    .SetHealth(500)
                    .SetAttackDamage(50)
                    .SetWeapon("Sword")
                    .GetEnemy();
        }
    }
}
