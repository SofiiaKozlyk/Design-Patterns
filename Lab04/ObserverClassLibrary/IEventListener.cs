using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClassLibrary
{
    public interface IEventListener
    {
        public string EventType { get; }
        public Action<LightElementNode> EventAction { get; }
        public void Update(LightElementNode lightElementNode);
    }
}
