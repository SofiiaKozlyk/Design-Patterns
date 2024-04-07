using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    public class Triangle : Shape
    {
        protected override string Type => "Triangle";
        public Triangle(IRenderer renderer) : base(renderer)
        {
        }
    }
}
