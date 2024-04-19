using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClassLibrary
{
    public class FourthSupportHandler : SupportHandler
    {
        public override void HandleRequest(string problem)
        {
            if (problem == "4")
            {
                Console.WriteLine("The solution to problem #4");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(problem);
            }
        }
    }
}
