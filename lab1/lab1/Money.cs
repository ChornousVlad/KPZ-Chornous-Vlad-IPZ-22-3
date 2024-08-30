using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Money
    {
        protected int wholePart;
        protected int coinPart;

        public Money(int wholePart, int coinPart)
        {
            if (wholePart < 0 || coinPart < 0)
            {
                throw new ArgumentException("Цілі та дробові частини мають бути додатніми числами.");
            }

            this.wholePart = wholePart;
            this.coinPart = coinPart;
        }

        public override string ToString()
        {
            return $"Сума сладає {this.wholePart} чогось та {this.coinPart} чогось.";
        }

        public void WriteSum()
        {
            Console.WriteLine(this);
        }

        public void setWholePArt(int wholePart)
        {
            this.wholePart = wholePart;
        }

        public int getWholePArt()
        {
            return this.wholePart;
        }

        public void setCoinPart(int coinPart)
        {
            this.coinPart = coinPart;
        }

        public int getCoinPart()
        {
            return this.coinPart;
        }
    }
}
