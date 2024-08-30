using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Lab2
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
        public void CreateMinimalViablePerson(int height, int weight)
        {
            this._builder.MakeWeight(height);
            this._builder.MakeHeight(weight);
        }

        public void CreateFullFeaturedPerson(int height, int weight, string skills, string equipment, string color, string hair)
        {
            this._builder.MakeWeight(height);
            this._builder.MakeHeight(weight);
            this._builder.MakeSkills(skills);
            this._builder.MakeEquipment(equipment);
            this._builder.MakeEyes(color);
            this._builder.MakeHair(hair);
        }
    }
}
