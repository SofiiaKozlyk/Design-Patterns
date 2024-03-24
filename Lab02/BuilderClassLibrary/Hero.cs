using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class Hero
    {
        public string Name { get; set; }
        private int _height;
        public int Height { get { return _height; } 
            set { 
                if(value < 0) throw new ArgumentOutOfRangeException("value");
                _height = value; 
            } }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Outfit { get; set; }
        public List<string> Inventory { get; set; }
        public Hero()
        {
            Inventory = new List<string>();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Build: {Build}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Outfit: {Outfit}");
            Console.WriteLine("Inventory:");
            foreach (string item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
