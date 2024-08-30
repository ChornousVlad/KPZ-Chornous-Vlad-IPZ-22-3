using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Dollar: Money
    {
        static string wholePartName = "$";
        static string coinPartName = "¢";

        protected string typeOfCurrency;

        public void setTypeOfCurrency(string typeOfCurrency)
        {
            this.typeOfCurrency = typeOfCurrency;
        }

        public string getTypeOfCurrency()
        {
            return this.typeOfCurrency;
        }

        public Dollar(string typeOfCurrency, int wholePart, int coinPart) : base(wholePart, coinPart)
        {
            this.typeOfCurrency = typeOfCurrency;
        }
        public override string ToString()
        {
            return $"Сума сладає {this.wholePart}{Dollar.wholePartName} та {this.coinPart}{Dollar.coinPartName} тип оплати {this.typeOfCurrency}.";
        }
    }
}
