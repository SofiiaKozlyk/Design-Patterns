using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClassLibrary
{
    public interface ITextDocumentMemento
    {
        public string GetState();
    }
}
