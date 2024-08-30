using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextReaderLocker
    {
        private SmartTextReader _reader;
        private string _regexPattern;

        public SmartTextReaderLocker(SmartTextReader reader, string regexPattern)
        {
            _reader = reader;
            _regexPattern = regexPattern;
        }

        public char[][] ReadFile(string filePath)
        {
            if (Regex.IsMatch(filePath, _regexPattern))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }

            return _reader.ReadFile(filePath);
        }
    }
}
