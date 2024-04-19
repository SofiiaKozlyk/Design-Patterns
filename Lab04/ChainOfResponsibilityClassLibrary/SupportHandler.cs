using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary
{
    public abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;
        public void SetNextHandler(SupportHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
        public abstract void HandleRequest(string problem);
    }
}
