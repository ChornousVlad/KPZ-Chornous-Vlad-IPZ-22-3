using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ChangeStyleCommand : ICommand
    {
        private readonly LightElementNode _element;
        private readonly string _styleName;
        private readonly string _newValue;
        private string _previousValue;

        public ChangeStyleCommand(LightElementNode element, string styleName, string newValue)
        {
            _element = element;
            _styleName = styleName;
            _newValue = newValue;
        }

        public void Execute()
        {
            _previousValue = _element.Style.ContainsKey(_styleName) ? _element.Style[_styleName] : null;

            _element.Style[_styleName] = _newValue;
        }

        public void Undo()
        {
            if (_previousValue != null)
            {
                _element.Style[_styleName] = _previousValue;
            }
            else
            {
                _element.Style.Remove(_styleName);
            }
        }
    }

}
