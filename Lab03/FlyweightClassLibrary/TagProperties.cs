using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightClassLibrary
{
    public class TagProperties
    {
        public string TagName;
        public string DisplayType;
        public string ClosingType;
        public List<string> CssClasses;
        public TagProperties(string tag, string displayType, string closingType, List<string> cssClasses)
        {
            TagName = tag;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
        }
    }
}
