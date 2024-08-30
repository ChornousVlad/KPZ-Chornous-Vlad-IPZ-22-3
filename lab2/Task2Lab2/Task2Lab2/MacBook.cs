using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab2
{
    public class MacBook: IAbstractLaptop
    {
        public string LaptopCreation()
        {
            return "Створено MacBook компанії Apple";
        }
    }
}