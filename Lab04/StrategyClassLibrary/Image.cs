using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public class Image
    {
        private IImageLoadStrategy _imageLoadStrategy;
        public Image()
        {
        }
        public Image(IImageLoadStrategy imageLoadStrategy)
        {
            this._imageLoadStrategy = imageLoadStrategy;
        }
        public void SetImageLoadStrategy(IImageLoadStrategy imageLoadStrategy)
        {
            this._imageLoadStrategy = imageLoadStrategy;
        }
        public void LoadImage(string href)
        {
            this._imageLoadStrategy.LoadImage(href);
        }
    }
}
