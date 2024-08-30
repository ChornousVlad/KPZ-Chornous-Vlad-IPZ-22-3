using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Hryvnia: Money
    {
        static string wholePartName = "₴";
        static string coinPartName = "K";

        protected bool forgery;

        public void setForgery(bool forgery)
        {
            this.forgery = forgery;
        }

        public bool getForgery()
        {
            return this.forgery;
        }

        public Hryvnia(bool forgery, int wholePart, int coinPart) : base(wholePart, coinPart)
        {
            this.forgery = forgery;
        }

        private string checkTruelty()
        {
            if (this.forgery)
            {
                return "гроші підроблені";
            } else
            {
                return "гроші дійсні";
            }
        }
        public override string ToString()
        {
            return $"Сума сладає {this.wholePart}{Hryvnia.wholePartName} та {this.coinPart}{Hryvnia.coinPartName} {checkTruelty()}.";
        }
    }
}
