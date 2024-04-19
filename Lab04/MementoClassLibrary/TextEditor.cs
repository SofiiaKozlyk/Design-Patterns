using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClassLibrary
{
    public class TextEditor
    {
        private List<ITextDocumentMemento> _mementos = new List<ITextDocumentMemento>();
        private TextDocument _textDocument = null;
        public TextEditor(TextDocument textDocument)
        {
            this._textDocument = textDocument;
        }
        public void Save()
        {
            Console.WriteLine($"Saving {this._textDocument.Title}'s content...");
            this._mementos.Add(this._textDocument.makeSnapshot());
        }
        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                Console.WriteLine("Undo: No previous content saved.");
                return;
            }
            var memento = this._mementos.Last();
            this._mementos.Remove(memento);
            this._textDocument.Restore(memento);
        }
    }
}
