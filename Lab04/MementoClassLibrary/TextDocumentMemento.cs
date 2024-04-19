using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClassLibrary
{
    public class TextDocumentMemento : ITextDocumentMemento
    {
        private string _state;
        public TextDocumentMemento(string state)
        {
            this._state = state;
        }
        public string GetState()
        {
            return this._state;
        }
    }
}
