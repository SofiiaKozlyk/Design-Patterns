using CompositeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClassLibrary
{
    public class AddNodeCommand : ICommand
    {
        private readonly LightElementNode _parentNode;
        private readonly LightNode _childNode;
        public AddNodeCommand(LightElementNode parentNode, LightNode childNode)
        {
            _parentNode = parentNode;
            _childNode = childNode;
        }
        public void Execute()
        {
            _parentNode.Add(_childNode);
        }
    }
}
