using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodClassLibrary
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base("Educational", 20.75, 9, new List<string> { "EducationalChannel1", "EducationalChannel2", "EducationalChannel3" })
        {
        }
    }
}
