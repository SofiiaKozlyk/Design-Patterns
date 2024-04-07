using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProxyClassLibrary
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private ISmartTextReader _reader;
        private Regex _regex;
        public SmartTextReaderLocker(string pattern)
        {
            _reader = new SmartTextReader();
            _regex = new Regex(pattern);
        }
        public string[,] ReadText(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            else
            {
                return _reader.ReadText(filePath);
            }
        }
    }
}
