using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public class KiaomiFactory : IDeviceFactory
    {
        public Device CreateLaptop(string model)
        {
            return new Laptop(model, "Kiaomi");
        }
        public Device CreateNetbook(string model)
        {
            return new Netbook(model, "Kiaomi");
        }
        public Device CreateEBook(string model)
        {
            return new EBook(model, "Kiaomi");
        }
        public Device CreateSmartphone(string model)
        {
            return new Smartphone(model, "Kiaomi");
        }
    }
}
