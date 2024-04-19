using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary
{
    public class FirstSupportHandler : SupportHandler
    {
        public override void HandleRequest(string problem)
        {
            if (problem == "1")
            {
                Console.WriteLine("The solution to problem #1");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(problem);
            }
        }
    }
}
