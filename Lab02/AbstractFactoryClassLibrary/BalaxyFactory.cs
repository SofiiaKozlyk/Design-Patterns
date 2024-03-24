using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public class BalaxyFactory : IDeviceFactory
    {
        public Device CreateLaptop(string model)
        {
            return new Laptop(model, "Balaxy");
        }
        public Device CreateNetbook(string model)
        {
            return new Netbook(model, "Balaxy");
        }
        public Device CreateEBook(string model)
        {
            return new EBook(model, "Balaxy");
        }
        public Device CreateSmartphone(string model)
        {
            return new Smartphone(model, "Balaxy");
        }
    }
}
