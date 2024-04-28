using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassLibrary.StateClasses
{
    public interface INodeState
    {
        public void SetLightNode(LightElementNode lightNode);
        public string Handle();
    }
}
