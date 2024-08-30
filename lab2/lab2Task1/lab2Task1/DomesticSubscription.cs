using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Task1
{
    public class DomesticSubscription : ISubscription
    {
        int pricePerMonth = 20;
        int minSubPeriod = 3;
        List<string> Posibilities = new List<string> { "Перегляд всіх розважальних каналів", "Доступ до 100 платних фільмів", "Безкоштовні курси фінансової грамотності", "ІсторіяТБ", "Література Світу ТБ"};

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
