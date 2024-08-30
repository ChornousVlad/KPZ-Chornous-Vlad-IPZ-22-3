using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Lab2
{
    public class Enemy
    {
        private List<object> _stats = new List<object>();
        private List<object> _badThings = new List<object>();

        public void Add(string stat)
        {
            this._stats.Add(stat);
        }

        public void AddActions(string action)
        {
            this._badThings.Add(action);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._stats.Count; i++)
            {
                str += this._stats[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            str += "Very Bad Actions:\n";

            for (int i = 0; i < this._badThings.Count; i++)
            {
                str += this._badThings[i] + ", ";
            }

            str = str.Remove(str.Length - 2);
            return "Hero stats: " + str + "\n";
        }
    }
}
