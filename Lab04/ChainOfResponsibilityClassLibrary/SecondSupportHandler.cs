using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary
{
    public class SecondSupportHandler : SupportHandler
    {
        public override void HandleRequest(string problem)
        {
            if (problem == "2")
            {
                Console.WriteLine("The solution to problem #2");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(problem);
            }
        }
    }
}
