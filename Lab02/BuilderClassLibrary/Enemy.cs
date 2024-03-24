using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class Enemy
    {
        public string Name { get; set; }
        public string Class { get; set; }
        private int _level;
        public int Level { get { return _level; } 
            set {
                if (value < 0) throw new ArgumentOutOfRangeException("value");
                _level = value; 
            } }
        private int _health;
        public int Health { get { return _health; } 
            set {
                if (value < 0) throw new ArgumentOutOfRangeException("value");
                _health = value;
            } }
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
        public string Weapon { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack Damage: {AttackDamage}");
            Console.WriteLine($"Weapon: {Weapon}");
        }
    }
}
