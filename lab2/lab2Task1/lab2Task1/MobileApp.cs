using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Task1
{
    public class MobileApp: Source
    {
        public override ISubscription CreateSubscription()
        {
            return new EducationalSubscription();
        }
    }
}
