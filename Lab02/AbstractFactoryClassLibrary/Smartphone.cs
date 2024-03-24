using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public class Smartphone : Device
    {
        public Smartphone(string model, string brand) : base("Smartphone", model, brand)
        {
        }
    }
}
