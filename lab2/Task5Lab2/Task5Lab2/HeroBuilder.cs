using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Lab2
{
    public class HeroBuilder: IBuilder
    {
        private Hero _hero = new Hero();

        public HeroBuilder() 
        {
            this.Reset();
        }

        public void Reset()
        {
            this._hero = new Hero();
        }
        public void MakeEyes(string color)
        {
            this._hero.Add($"Eyes: {color}");
        }

        public void MakeHeight(int height)
        {
            this._hero.Add($"Height: {height}");
        }

        public void MakeWeight(int weight)
        {
            this._hero.Add($"Weight: {weight}");
        }

        public void MakeEquipment(string equipment)
        {
            this._hero.Add($"Equipment: {equipment}");
        }

        public void MakeHair(string hair)
        {
            this._hero.Add($"Hair: {hair}");
        }

        public void MakeSkills(string skills) 
        {
            this._hero.Add($"Skills: {skills}");
        }
        public void AddActions(string action)
        {
            this._hero.AddActions(action);
        }

        public Hero GetHero()
        {
            Hero result = this._hero;

            this.Reset();

            return result;
        }
    }
}
