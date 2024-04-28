using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeClassLibrary.VisitorClasses
{
    public class NodeVisitor : IVisitor
    {
        public void Visit(LightTextNode lightTextNode)
        {
            Console.WriteLine($"Visited LightTextNode: \"{lightTextNode.Text}\"");
        }
        public void Visit(LightElementNode lightElementNode)
        {
            Console.WriteLine($"Visited LightElementNode: \"{lightElementNode.Tag}\"");
        }
    }
}
