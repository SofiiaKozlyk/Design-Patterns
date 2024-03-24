using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary
{
    public class EBook : Device
    {
        public EBook(string model, string brand) : base("EBook", model, brand)
        {
        }
    }
}
