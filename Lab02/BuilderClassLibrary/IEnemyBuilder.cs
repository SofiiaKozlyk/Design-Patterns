using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public interface IEnemyBuilder
    {
        public IEnemyBuilder SetName(string name);
        public IEnemyBuilder SetClass(string enemyClass);
        public IEnemyBuilder SetLevel(int level);
        public IEnemyBuilder SetHealth(int health);
        public IEnemyBuilder SetAttackDamage(int attackDamage);
        public IEnemyBuilder SetWeapon(string weapon);
        public Enemy GetEnemy();
    }
}
