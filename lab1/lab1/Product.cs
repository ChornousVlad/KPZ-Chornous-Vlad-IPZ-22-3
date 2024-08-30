using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Product
    {
        protected Money price;
        protected string category;

        public Product(Money price, string category)
        {
            this.price = price;
            this.category = category;
        }

        public void setPrice(Money price)
        {
            this.price = price;
        }

        public Money getPrice()
        {
            return this.price;
        }

        public void setCategory(string price)
        {
            this.category = category;
        }

        public string getCategory()
        {
            return this.category;
        }


        protected bool checkPlurality(int wholePart, int coinPart)
        {
            if (this.price.getWholePArt() - wholePart >= 0 && this.price.getCoinPart() - coinPart >=0) 
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void decreasePrice(int wholePart, int coinPart)
        {
            if(checkPlurality(wholePart, coinPart))
            {
                this.price.setWholePArt(wholePart);
                this.price.setCoinPart(coinPart);
            }
        }

        public override string ToString()
        {
            return $"Ціна за одиницю: {this.price}. Категорія: {this.category}";
        }
    }
}
