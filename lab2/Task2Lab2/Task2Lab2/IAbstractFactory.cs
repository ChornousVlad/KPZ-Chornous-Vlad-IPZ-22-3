using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab2
{
    public interface IAbstractFactory
    {
        IAbstractLaptop CreateLaptop();
        IAbstractSmartphone CreateSmartphone();
        IAbstractNetBook CreateNetBook();
    }
}