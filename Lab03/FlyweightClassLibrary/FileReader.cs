using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CompositeClassLibrary;

namespace FlyweightClassLibrary
{
    public static class FileReader
    {
        public static NewLightElementNode ConvertTextWithFly(string filePath)
        {
            NewLightElementNode root = new NewLightElementNode("html", "block", "closed", new List<string>());
            NewLightElementNode body = new NewLightElementNode("body", "block", "closed", new List<string>());
            root.Add(body);
            string[] lines = System.IO.File.ReadAllLines(filePath);
            long memoryBefore = GC.GetTotalMemory(false);
            bool firstLine = true;
            foreach (string line in lines)
            {
                string element;
                if (line.Length < 20)
                {
                    element = "h2";
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    element = "blockquote";
                }
                else
                {
                    element = "p";
                }

                if (firstLine)
                {
                    element = "h1";
                    firstLine = false;
                }
                var tag = new NewLightElementNode(element, "block", "closed", new List<string>());
                tag.Add(new LightTextNode(line));
                body.Add(tag);
            }
            Console.WriteLine((GC.GetTotalMemory(false) - memoryBefore) / 1024f / 1024f + " MB");
            return root;
        }
        public static LightElementNode ConvertTextWithoutFly(string filePath)
        {
            LightElementNode root = new LightElementNode("html", "block", "closed", new List<string>());
            LightElementNode body = new LightElementNode("body", "block", "closed", new List<string>());
            root.Add(body);
            string[] lines = System.IO.File.ReadAllLines(filePath);
            long memoryBefore = GC.GetTotalMemory(false);
            bool firstLine = true;
            foreach (string line in lines)
            {
                string element;
                if (line.Length < 20)
                {
                    element = "h2";
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    element = "blockquote";
                }
                else
                {
                    element = "p";
                }

                if (firstLine)
                {
                    element = "h1";
                    firstLine = false;
                }
                var tag = new LightElementNode(element, "block", "closed", new List<string>());
                tag.Add(new LightTextNode(line));
                body.Add(tag);
            }
            Console.WriteLine((GC.GetTotalMemory(false) - memoryBefore) / 1024f / 1024f + " MB");
            return root;
        }
    }
}
