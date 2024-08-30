using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextChecker
    {
        private SmartTextReader _reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine("Opening file...");
            char[][] result = _reader.ReadFile(filePath);
            Console.WriteLine("File successfully read.");
            Console.WriteLine("Closing file...");

            int lineCount = result.Length;
            int charCount = 0;
            foreach (var line in result)
            {
                charCount += line.Length;
            }

            Console.WriteLine($"Total lines: {lineCount}, Total characters: {charCount}");

            return result;
        }
    }
}
