using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassLibrary
{
    public class FileLogger : Logger
    {
        private FileWriter _fileWriter;
        public FileLogger(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }
        public void Log(string message)
        {
            _fileWriter.WriteLine($"Log: {message}");
        }
        public void Error(string message)
        {
            _fileWriter.WriteLine($"Error: {message}");
        }
        public void Warn(string message)
        {
            _fileWriter.WriteLine($"Warn: {message}");
        }
    }
}
