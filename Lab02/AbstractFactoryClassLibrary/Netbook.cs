using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public class Netbook : Device
    {
        public Netbook(string model, string brand) : base("Netbook", model, brand)
        {
        }
    }
}
