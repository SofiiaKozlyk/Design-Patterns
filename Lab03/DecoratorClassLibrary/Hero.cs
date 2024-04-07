using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public abstract class Hero
    {
        public string Name;
        private int _protection;
        public int Protection
        {
            get { return _protection; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value");
                _protection = value;
            }
        }
        private int _attackDamage;
        public int AttackDamage
        {
            get { return _attackDamage; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value");
                _attackDamage = value;
            }
        }
        public Hero(string name, int protection, int attackDamage)
        {
            Name = name;
            Protection = protection;
            AttackDamage = attackDamage;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Protection: {Protection}, AttackDamage: {AttackDamage}");
        }
    }
}
