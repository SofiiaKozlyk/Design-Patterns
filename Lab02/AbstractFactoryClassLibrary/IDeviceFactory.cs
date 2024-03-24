using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public interface IDeviceFactory
    {
        public Device CreateLaptop(string model);
        public Device CreateNetbook(string model);
        public Device CreateEBook(string model);
        public Device CreateSmartphone(string model);
    }
}
