using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class EditStyleState : IElementState
    {
        public void HandleStyleEditing(LightElementNode element, string styleName, string newValue)
        {
            element.Style[styleName] = newValue;
        }

        public void HandleTextInsertion(LightElementNode element, string text)
        {
            throw new InvalidOperationException("Cannot insert text while editing styles.");
        }
    }
}
