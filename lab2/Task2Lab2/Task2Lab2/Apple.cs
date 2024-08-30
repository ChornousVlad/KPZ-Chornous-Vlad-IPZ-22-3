using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab2
{
    public class Apple: IAbstractFactory
    {
        public IAbstractLaptop CreateLaptop()
        {
            return new MacBook();
        }

        public IAbstractSmartphone CreateSmartphone()
        {
            return new Iphone();
        }

        public IAbstractNetBook CreateNetBook()
        {
            return new AppleNetBook();
        }
    }
}