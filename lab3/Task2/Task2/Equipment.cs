using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Equipment : Hero
    {
        private readonly Hero _hero;

        protected Equipment(Hero hero)
        {
            _hero = hero;
        }

        public override void Display()
        {
            _hero.Display();
        }
    }
}
