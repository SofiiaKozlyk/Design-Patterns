using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyClassLibrary
{
    public class SmartTextReader : ISmartTextReader
    {
        public string[,] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[,] textArray = new string[lines.Length, lines[0].Length];
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    textArray[i, j] = lines[i][j].ToString();
                }
            }
            return textArray;
        }
    }
}
