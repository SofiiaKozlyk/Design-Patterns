using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyClassLibrary
{
    public class SmartTextChecker : ISmartTextReader
    {
        private ISmartTextReader _reader;
        public SmartTextChecker()
        {
            _reader = new SmartTextReader();
        }
        public string[,] ReadText(string filePath)
        {
            Console.WriteLine("Opening file...");
            string[,] textArray = _reader.ReadText(filePath);
            Console.WriteLine("File read successfully.");
            Console.WriteLine($"Total lines: {textArray.GetLength(0)}");
            Console.WriteLine($"Total characters: {textArray.Length}");
            Console.WriteLine("Closing file...");
            return textArray;
        }
    }
}
