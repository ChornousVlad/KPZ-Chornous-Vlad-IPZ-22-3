using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Lab2
{
    public class Hero
    {
        private List<object> _stats = new List<object>();
        private List<object> _goodThings = new List<object>();

        public void Add(string stat)
        {
            this._stats.Add(stat);
        }
        public void AddActions(string action)
        {
            this._goodThings.Add(action);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._stats.Count; i++)
            {
                str += this._stats[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            str += "Very Good Actions:\n";

            for (int i = 0; i < this._goodThings.Count; i++)
            {
                str += this._goodThings[i] + ", ";
            }

            str = str.Remove(str.Length - 2);
            return "Hero stats: " + str + "\n";
        }
    }
}
