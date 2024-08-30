using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Task1
{
    public class ManagerCall: Source
    {
        public override ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
}
