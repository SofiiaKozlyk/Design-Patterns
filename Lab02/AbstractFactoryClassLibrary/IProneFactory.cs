using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public class IProneFactory : IDeviceFactory
    {
        public Device CreateLaptop(string model)
        {
            return new Laptop(model, "IProne");
        }
        public Device CreateNetbook(string model)
        {
            return new Netbook(model, "IProne");
        }
        public Device CreateEBook(string model)
        {
            return new EBook(model, "IProne");
        }
        public Device CreateSmartphone(string model)
        {
            return new Smartphone(model, "IProne");
        }
    }
}
