using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClassLibrary
{
    public class TextDocument
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public TextDocument(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public ITextDocumentMemento makeSnapshot()
        {
            return new TextDocumentMemento(this.Content);
        }
        public void Restore(ITextDocumentMemento memento)
        {
            this.Content = memento.GetState();
            Console.WriteLine($"{Title}'s content has changed to: {this.Content}");
        }
        public override string ToString()
        {
            return Content;
        }
    }
}
