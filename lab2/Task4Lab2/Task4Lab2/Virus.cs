using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Lab2
{
    public class Virus : Prototype
    {
        private float weight;
        private int age;
        public string name;
        private string type;
        private List<Virus> children;

        public Virus(float weight, int age, string name, string type)
        {
            this.weight = weight;
            this.age = age;
            this.name = name;
            this.type = type;
            this.children = new List<Virus>();
        }

        public Virus()
        {
            this.weight = 1;
            this.age = 1;
            this.name = "";
            this.type = "";
            this.children = new List<Virus>();
        }

        public Prototype Copy()
        {
            Virus copy = new Virus(this.weight, this.age, this.name, this.type);

            copy.children = this.children.ToList();

            this.children.Add(copy);

            return copy;
        }

        public void AddChild(Virus child)
        {
            this.children.Add(child);
        }

        public List<Virus> GetChildren()
        {
            return this.children;
        }

        public override string ToString()
        {
            string result = $"Name: {this.name}, Type: {this.type}, Weight: {this.weight}, Age: {this.age}\n";
            if (this.children.Count > 0)
            {
                result += "Children:\n";
                foreach (var child in this.children)
                {
                    result += child.ToString();
                }
            }
            return result;
        }
    }
}