using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LightHTMLElementIterator : IIterator<LightNode>
    {
        private readonly List<LightNode> _elements;
        private int _current = 0;

        public LightHTMLElementIterator(List<LightNode> elements)
        {
            _elements = elements;
        }

        public LightNode First()
        {
            _current = 0;
            return _elements[_current];
        }

        public LightNode Next()
        {
            _current++;
            return _current < _elements.Count ? _elements[_current] : null;
        }

        public bool IsDone()
        {
            return _current >= _elements.Count;
        }

        public LightNode CurrentItem()
        {
            return _elements[_current];
        }
    }

}
