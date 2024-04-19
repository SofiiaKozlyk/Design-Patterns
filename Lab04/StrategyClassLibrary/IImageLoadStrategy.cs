using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public interface IImageLoadStrategy
    {
        public void LoadImage(string href);
    }
}
