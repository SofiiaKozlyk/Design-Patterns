using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlyweightClassLibrary
{
    public static class TagPropertiesFactory
    {
        private static Dictionary<string, TagProperties> _flyweights = new Dictionary<string, TagProperties>();

        public static TagProperties GetTagProperties(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            if (!_flyweights.ContainsKey(tagName))
            {
                _flyweights.Add(tagName, new TagProperties(tagName, displayType, closingType, cssClasses));
            }
            return _flyweights[tagName];
        }
    }
}
