using CompositeClassLibrary.StateClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeClassLibrary
{
    public class LightElementNode : LightNode
    {
        private string _tag;
        private string _displayType;
        private string _closingType;
        private List<string> _cssClasses;
        private List<LightNode> _children;
        public List<LightNode> Children { 
            get { return _children; }
        }
        private INodeState _state = null;
        public LightElementNode(string tag, string displayType, string closingType, List<string> cssClasses)
        {
            _tag = tag;
            _displayType = displayType;
            _closingType = closingType;
            _cssClasses = cssClasses;
            _children = new List<LightNode>();
            _state = new DefaultState();
            _state.SetLightNode(this);
            this.AddLifecycleHooks();
        }
        public void TransitionTo(INodeState state)
        {
            this._state = state;
            this._state.SetLightNode(this);
        }
        public void Add(LightNode node)
        {
            _children.Add(node);
            if(node is LightTextNode lightTextNode)
            {
                lightTextNode.OnInserted();
            }
        }
        public void Remove(LightNode node)
        {
            _children.Remove(node);
        }
        public override string OuterHTML => _state.Handle();
        public override string InnerHTML => String.Join("", _children.ConvertAll(child => child.OuterHTML));
        public override string Display(int depth)
        {
            string str = "";
            str += new string(' ', depth) + $"<{_tag} class=\"{_displayType} {string.Join(" ", _cssClasses)}\"";
            str += _closingType == "notClosed" ? " />\n" : ">\n";
            foreach (var child in _children)
            {
                str += child.Display(depth + 2);
            }
            if (_closingType != "notClosed")
            {
                str += new string(' ', depth) + $"</{_tag}>\n";
            }
            return str;
        }
        public override void OnCreated()
        {
            Console.WriteLine($"LightElementNode {this._tag} created.");
        }
        public override void OnClassListApplied()
        {
            if(this._cssClasses.Count > 0)
            {
                Console.WriteLine($"{this._tag}`s class list applied.");
            }
        }
        public override IEnumerator<LightNode> GetEnumerator()
        {
            yield return this;
            foreach (var child in _children)
            {
                foreach(var node in child)
                {
                    yield return node;
                }
            }
        }
    }
}
