using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    public class Circle : Shape
    {
        protected override string Type => "Circle";
        public Circle(IRenderer renderer) : base(renderer)
        {
        }
    }
}
