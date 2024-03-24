using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeClassLibrary
{
    public class Virus : IVirusPrototype
    {
        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value");
                _weight = value;
            }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value");
                _age = value;
            }
        }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }
        public Virus(double weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = new List<Virus>();
        }
        public Virus(Virus virus)
        {
            this.Weight = virus.Weight;
            this.Age = virus.Age;
            this.Name = virus.Name;
            this.Species = virus.Species;
            this.Children = virus.Children;
        }
        public void AddChild(Virus child)
        {
            Children.Add(child);
        }
        public IVirusPrototype Clone()
        {
            return new Virus(this);
        }
        public void DisplayInfo(int depth = 0)
        {
            string indent = new string(' ', depth * 4);
            Console.WriteLine($"{indent}Name: {Name}, Species: {Species}, Weight: {Weight}, Age: {Age}");
            if(Children.Count > 0)
            {
                Console.WriteLine($"{indent}Child of {Name}:");
                foreach (Virus child in Children)
                {
                    child.DisplayInfo(depth + 1);
                }
            }
        }
    }
}
