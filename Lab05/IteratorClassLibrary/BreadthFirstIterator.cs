using CompositeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorClassLibrary
{
    public class BreadthFirstIterator : IEnumerator<LightNode>
    {
        private Queue<LightNode> _queue = new Queue<LightNode>();
        public BreadthFirstIterator(LightNode node)
        {
            _queue.Enqueue(node);
        }
        public LightNode Current => _queue.Peek();

        object System.Collections.IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (_queue.Count == 0)
            {
                return false;
            }

            var currentNode = _queue.Dequeue();
            if (currentNode is LightElementNode node)
            {
                foreach (LightNode child in node.Children.Reverse<LightNode>())
                {
                    _queue.Enqueue(child);
                }
            }

            return _queue.Count > 0;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
