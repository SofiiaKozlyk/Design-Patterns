using CompositeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeClassLibrary;

namespace FlyweightClassLibrary
{
    public class NewLightElementNode : LightNode
    {
        private TagProperties _tag;
        private List<LightNode> _children;
        public NewLightElementNode(string tag, string displayType, string closingType, List<string> cssClasses)
        {
            _tag = TagPropertiesFactory.GetTagProperties(tag, displayType, closingType, cssClasses);
            _children = new List<LightNode>();
        }
        public void Add(LightNode node)
        {
            _children.Add(node);
        }
        public void Remove(LightNode node)
        {
            _children.Remove(node);
        }
        public override string OuterHTML => Display(0);
        public override string InnerHTML
        {
            get
            {
                string str = "";
                foreach (var child in _children)
                {
                    str += child.OuterHTML;
                }
                return str;
            }
        }
        public override string Display(int depth)
        {
            string str = "";
            str += new string(' ', depth) + $"<{_tag.TagName} class=\"{_tag.DisplayType} {string.Join(" ", _tag.CssClasses)}\"";
            str += _tag.ClosingType == "notClosed" ? " />\n" : ">\n";
            foreach (var child in _children)
            {
                str += child.Display(depth + 2);
            }
            if (_tag.ClosingType != "notClosed")
            {
                str += new string(' ', depth) + $"</{_tag.TagName}>\n";
            }
            return str;
        }
    }
}
