using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeClassLibrary
{
    public class RasterRenderer : IRenderer
    {
        public void RenderShape(string shape)
        {
            Console.WriteLine($"Drawing {shape} as raster graphics");
        }
    }
}
