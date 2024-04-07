using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassLibrary
{
    public class FileWriter
    {
        private StreamWriter _file;
        public FileWriter(string filePath)
        {
            _file = new StreamWriter(filePath, true);
        }
        public void Write(string text)
        {
            _file.Write(text);
        }
        public void WriteLine(string text)
        {
            _file.WriteLine(text);
        }
        public void Close()
        {
            _file.Close();
        }
    }
}
