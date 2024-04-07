using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyClassLibrary
{
    public interface ISmartTextReader
    {
        public string[,] ReadText(string filePath);
    }
}
