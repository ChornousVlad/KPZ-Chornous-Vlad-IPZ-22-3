﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task2
{
    public class Weapon : Equipment
    {
        public Weapon(Hero hero) : base(hero) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Weapon equipped");
        }
    }
}
