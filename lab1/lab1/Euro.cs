using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Euro: Money
    {
        static string wholePartName = "€";
        static string coinPartName = "₡";

        protected string countryOfUsage;

        public void setCountryOfUsage(string countryOfUsage)
        {
            this.countryOfUsage = countryOfUsage;
        }

        public string getCountryOfUsage()
        {
            return this.countryOfUsage;
        }

        public Euro(string countryOfUsage, int wholePart, int coinPart) : base(wholePart, coinPart)
        {
            this.countryOfUsage = countryOfUsage;
        }
        public override string ToString()
        {
            return $"Сума сладає {this.wholePart}{Euro.wholePartName} та {this.coinPart}{Euro.coinPartName} країна використання {this.countryOfUsage}.";
        }
    }
}
