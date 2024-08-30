using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Reporting
    {
        private List<Warehouse> warehouseItems;
        private string incomeReport;
        private string outgoingReport;

        public Reporting()
        {
            warehouseItems = new List<Warehouse>();
            incomeReport = string.Empty;
            outgoingReport = string.Empty;
        }

        public void RegisterIncomingGoods(Warehouse item)
        {
            if (warehouseItems.Contains(item))
            {
                int index = warehouseItems.FindIndex(x => x.Equals(item));
                warehouseItems[index].setQuantity(warehouseItems[index].getQuantity() + item.getQuantity());
            }
            else
            {
                warehouseItems.Add(item);
                this.incomeReport += "\n" + item;
            }
        }

        public void RegisterOutgoingGoods(Warehouse item)
        {
            if (warehouseItems.Contains(item))
            {
                int index = warehouseItems.FindIndex(x => x.Equals(item));
                if(warehouseItems[index].getQuantity() == item.getQuantity())
                {
                    warehouseItems.Remove(item);
                    this.outgoingReport += "\n" + item;
                } 
                else if(warehouseItems[index].getQuantity() >= item.getQuantity())
                {
                    warehouseItems[index].setQuantity(warehouseItems[index].getQuantity() - item.getQuantity());
                    this.outgoingReport += "\n" + item;
                }
                
            }
            else
            {
                Console.WriteLine("Такого товару на складі немає.");
            }
        }

        public void GenerateIncomingReport()
        {
            Console.WriteLine($"Звіт надходжень{this.incomeReport}");
        }

        public void GenerateOutgoingReport()
        {
            Console.WriteLine($"Звіт відправлень{this.outgoingReport}");
        }

        public void GenerateInventoryReport()
        {
            Console.WriteLine("Звіт по інвентаризації:");

            foreach (var item in warehouseItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}