using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab2
{
    public class Asus: IAbstractFactory
    {
        public IAbstractLaptop CreateLaptop()
        {
            return new AsusLaptop();
        }

        public IAbstractSmartphone CreateSmartphone()
        {
            return new AsusPhone();
        }

        public IAbstractNetBook CreateNetBook()
        {
            return new AsusNetBook();
        }
    }
}
