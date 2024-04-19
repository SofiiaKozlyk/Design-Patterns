using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClassLibrary
{
    public class EventListener : IEventListener
    {
        public string EventType { get; }
        public Action<LightElementNode> EventAction { get; }
        public EventListener(string eventType, Action<LightElementNode> eventAction)
        {
            EventType = eventType;
            EventAction = eventAction;
        }
        public void Update(LightElementNode lightElementNode)
        {
            this.EventAction.Invoke(lightElementNode);
        }
    }
}
