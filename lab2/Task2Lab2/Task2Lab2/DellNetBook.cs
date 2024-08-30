using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab2
{
    public class DellNetBook: IAbstractNetBook
    {
        public string NetbookCreation()
        {
            return "Створено нетбук компанії Dell";
        }
    }
}
