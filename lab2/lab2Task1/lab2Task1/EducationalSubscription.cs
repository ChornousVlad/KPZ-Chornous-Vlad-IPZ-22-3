using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Task1
{
    public class EducationalSubscription: ISubscription
    {
        int pricePerMonth = 5;
        int minSubPeriod = 1;
        List<string> Posibilities = new List<string> { "Перегляд всіх наукових каналів", "Доступ до 100 документальних фільмів", "Курси frontend"};

        public override string ToString()
        {
            string result = $"Ціна на підписку складає: {this.pricePerMonth}$\nМінімальний термін оформлення: {this.minSubPeriod}\nМожливості, котрі надаються:\n";
            this.Posibilities.ForEach(item => result += $"{item}\n");
            return result;
        }

        public string showSubscriptionParametres()
        {
            return this.ToString();
        }
    }
}
