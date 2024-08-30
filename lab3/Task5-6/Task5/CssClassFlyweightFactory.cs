using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CssClassFlyweightFactory
    {
        private Dictionary<string, string> _cssClasses = new Dictionary<string, string>();

        public string GetCssClass(string className)
        {
            if (!_cssClasses.ContainsKey(className))
            {
                _cssClasses[className] = $"class=\"{className}\"";
            }
            return _cssClasses[className];
        }
    }
}
