using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Lab2
{
    public interface IBuilder
    {
        void MakeEyes(string color);
        void MakeHeight(int height);
        void MakeWeight(int weight);
        void MakeEquipment(string equipment);
        void MakeHair(string hair);
        void MakeSkills(string skills);
        void AddActions(string action);
    }
}
