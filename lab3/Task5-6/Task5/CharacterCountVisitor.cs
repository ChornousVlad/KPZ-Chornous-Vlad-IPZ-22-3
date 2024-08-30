using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CharacterCountVisitor : IVisitor
    {
        public int TotalCharacterCount { get; private set; }

        public CharacterCountVisitor()
        {
            TotalCharacterCount = 0;
        }

        public void Visit(LightTextNode node)
        {
            TotalCharacterCount += node.Text.Length;
        }

        public void Visit(LightElementNode node)
        {
            foreach (var child in node.Children)
            {
                if (child is LightTextNode textNode)
                {
                    Visit(textNode);
                }
                else if (child is LightElementNode elementNode)
                {
                    Visit(elementNode);
                }
            }
        }
    }

}
