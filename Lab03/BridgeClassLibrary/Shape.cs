using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    public abstract class Shape
    {
        protected IRenderer _renderer;
        protected abstract string Type { get; }

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }
        public void Draw()
        {
            _renderer.RenderShape(Type);
        }
    }
}
