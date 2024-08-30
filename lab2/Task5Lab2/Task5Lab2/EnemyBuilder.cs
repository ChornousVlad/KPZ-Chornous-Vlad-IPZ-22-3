using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Lab2
{
    public class EnemyBuilder : IBuilder
    {
        private Enemy _enemy = new Enemy();

        public EnemyBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._enemy = new Enemy();
        }
        public void MakeEyes(string color)
        {
            this._enemy.Add($"Eyes: {color}");
        }

        public void MakeHeight(int height)
        {
            this._enemy.Add($"Height: {height}");
        }

        public void MakeWeight(int weight)
        {
            this._enemy.Add($"Weight: {weight}");
        }

        public void MakeEquipment(string equipment)
        {
            this._enemy.Add($"Equipment: {equipment}");
        }

        public void MakeHair(string hair)
        {
            this._enemy.Add($"Hair: {hair}");
        }

        public void MakeSkills(string skills)
        {
            this._enemy.Add($"Skills: {skills}");
        }

        public void AddActions(string action)
        {
            this._enemy.AddActions(action);
        }

        public Enemy GetEnemy()
        {
            Enemy result = this._enemy;

            this.Reset();

            return result;
        }
    }
}
