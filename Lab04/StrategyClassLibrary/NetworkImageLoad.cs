using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public class NetworkImageLoad : IImageLoadStrategy
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"Loading image (href: {href}) from network.");
        }
    }
}
