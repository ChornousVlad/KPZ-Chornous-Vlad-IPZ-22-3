using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Task1
{
    public abstract class Source
    {
        public abstract ISubscription CreateSubscription();

        public string Subscribe()
        {
            var subscription = CreateSubscription();

            var result = $"Вас було підписано на таких умовах: {subscription}";

            return result;
        }
    }
}
