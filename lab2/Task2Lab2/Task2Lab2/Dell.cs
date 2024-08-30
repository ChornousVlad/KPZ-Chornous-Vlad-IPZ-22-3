using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab2
{
    public class Dell: IAbstractFactory
    {
        public IAbstractLaptop CreateLaptop()
        {
            return new DellLaptop();
        }

        public IAbstractSmartphone CreateSmartphone()
        {
            return new DellPhone();
        }

        public IAbstractNetBook CreateNetBook()
        {
            return new DellNetBook();
        }
    }
}
