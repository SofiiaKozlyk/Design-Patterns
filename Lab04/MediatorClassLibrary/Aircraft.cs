using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorClassLibrary
{
    public class Aircraft
    {
        public string Name;
        public bool IsTakingOff { get; set; }
        public Aircraft(string name)
        {
            this.Name = name;
            IsTakingOff = true;
        }
        public void Land()
        {
            if (this.IsTakingOff)
            {
                Console.WriteLine($"Aircraft {this.Name} has landed.");
            }
            else
            {
                Console.WriteLine($"Aircraft {this.Name} has already landed.");
            }
        }
        public void TakeOff()
        {
            if (!this.IsTakingOff)
            {
                Console.WriteLine($"Aircraft {this.Name} has took off.");
            }
            else
            {
                Console.WriteLine($"Aircraft {this.Name} has already took off.");
            }
        }
    }
}
