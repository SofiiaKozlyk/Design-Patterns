using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class EnemyBuilder :IEnemyBuilder
    {
        private Enemy _enemy = new Enemy();
        private void _reset()
        {
            this._enemy = new Enemy();
        }
        public IEnemyBuilder SetName(string name)
        {
            _enemy.Name = name;
            return this;
        }
        public IEnemyBuilder SetClass(string enemyClass)
        {
            _enemy.Class = enemyClass;
            return this;
        }
        public IEnemyBuilder SetLevel(int level)
        {
            _enemy.Level = level;
            return this;
        }
        public IEnemyBuilder SetHealth(int health)
        {
            _enemy.Health = health;
            return this;
        }
        public IEnemyBuilder SetAttackDamage(int attackDamage)
        {
            _enemy.AttackDamage = attackDamage;
            return this;
        }
        public IEnemyBuilder SetWeapon(string weapon)
        {
            _enemy.Weapon = weapon;
            return this;
        }
        public Enemy GetEnemy()
        {
            Enemy enemy = this._enemy;
            this._reset();
            return enemy;
        }
    }
}
