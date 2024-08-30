using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class InsertTextState : IElementState
    {
        public void HandleStyleEditing(LightElementNode element, string styleName, string newValue)
        {
            throw new InvalidOperationException("Cannot edit styles while inserting text.");
        }

        public void HandleTextInsertion(LightElementNode element, string text)
        {
            element.AddChild(new LightTextNode(text));
        }
    }
}
