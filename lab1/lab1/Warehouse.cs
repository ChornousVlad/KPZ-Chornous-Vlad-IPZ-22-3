using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Warehouse
    {
        protected string name;
        protected string unit;
        protected int quantity;
        protected Product characteristics;
        protected DateTime lastRestockDate;

        public Warehouse(string name, string unit, Product price, int quantity, DateTime lastRestockDate, Product characteristics)
        {
            this.unit = unit;
            this.quantity = quantity;
            this.lastRestockDate = lastRestockDate;
            this.characteristics = characteristics;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setUnit(string unit)
        {
            this.unit = unit;
        }
        public string getUnit()
        {
            return this.unit;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public DateTime getLastRestockDate()
        {
            return this.lastRestockDate;
        }

        public void setLastRestockDate(DateTime lastRestockDate)
        {
            this.lastRestockDate = new DateTime();
        }

        public override string ToString()
        {
            return $"Товар: {this.name} у кількості {this.quantity} {this.unit}, {this.characteristics}, дата надходження {getLastRestockDate().ToShortDateString()}";
        }
    }
}
