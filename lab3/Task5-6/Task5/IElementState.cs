using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public interface IElementState
    {
        void HandleStyleEditing(LightElementNode element, string styleName, string newValue);
        void HandleTextInsertion(LightElementNode element, string text);
    }

}
