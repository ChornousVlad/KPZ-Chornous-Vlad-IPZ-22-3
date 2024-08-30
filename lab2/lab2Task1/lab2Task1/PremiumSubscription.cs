using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Task1
{
    public class PremiumSubscription: ISubscription
    {
        int pricePerMonth = 45;
        int minSubPeriod = 6;
        List<string> Posibilities = new List<string> { "Перегляд всіх каналів", "Доступ до всіх фільмів на сервісі", "Всі доступні курси на ресурсі" };

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
