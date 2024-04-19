using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClassLibrary
{
    public interface ISubject
    {
        public void AddEventListener(IEventListener eventListener);
        public void RemoveEventListener(IEventListener eventListener);
        public void InvokeEvent(string eventType);
    }
}
