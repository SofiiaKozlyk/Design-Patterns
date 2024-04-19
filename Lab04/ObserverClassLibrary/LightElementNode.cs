using ObserverClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClassLibrary
{
    public class LightElementNode : LightNode, ISubject
    {
        private string _tag;
        public string Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        private string _displayType;
        private string _closingType;
        private List<string> _cssClasses;
        private List<LightNode> _children;
        private List<IEventListener> _eventListeners = new List<IEventListener>();
        public LightElementNode(string tag, string displayType, string closingType, List<string> cssClasses)
        {
            _tag = tag;
            _displayType = displayType;
            _closingType = closingType;
            _cssClasses = cssClasses;
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
            get {
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
        public void AddEventListener(IEventListener eventListener)
        {
            this._eventListeners.Add(eventListener);
        }
        public void RemoveEventListener(IEventListener eventListener)
        {
            this._eventListeners.Remove(eventListener);
        }
        public void InvokeEvent(string eventType)
        {
            _eventListeners
                    .Where(eventListener => eventListener.EventType == eventType)
                    .ToList()
                    .ForEach(eventListener => eventListener.Update(this));
        }
    }
}
