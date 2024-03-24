using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public class Laptop : Device
    {
        public Laptop(string model, string brand) : base("Laptop", model, brand)
        {
        }
    }
}
