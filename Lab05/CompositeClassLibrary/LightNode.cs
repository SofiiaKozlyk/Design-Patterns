using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeClassLibrary
{
    public abstract class LightNode : IEnumerable<LightNode>
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
        public abstract string Display(int depth);
        public virtual void OnCreated()
        {
        }
        public virtual void OnInserted()
        {
        }
        public virtual void OnClassListApplied()
        {
        }
        public void AddLifecycleHooks()
        {
            OnCreated();
            OnInserted();
            OnClassListApplied();
        }
        public virtual IEnumerator<LightNode> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
