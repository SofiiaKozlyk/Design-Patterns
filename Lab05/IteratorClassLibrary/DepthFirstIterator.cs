using CompositeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorClassLibrary
{
    public class DepthFirstIterator : IEnumerator<LightNode>
    {
        private Stack<LightNode> _stack = new Stack<LightNode>();
        public DepthFirstIterator(LightNode node)
        {
            _stack.Push(node);
        }
        public LightNode Current => _stack.Peek();

        object System.Collections.IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if(_stack.Count == 0)
            {
                return false;
            }

            var currentNode = _stack.Pop();
            if(currentNode is LightElementNode node)
            {
                foreach (LightNode child in node.Children.Reverse<LightNode>())
                {
                    _stack.Push(child);
                }
            }

            return _stack.Count > 0;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
