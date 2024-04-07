using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    public class Square : Shape
    {
        protected override string Type => "Square";
        public Square(IRenderer renderer) : base(renderer)
        {
        }
    }
}
