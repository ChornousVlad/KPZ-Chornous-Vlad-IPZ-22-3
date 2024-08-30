using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CreationLog
    {
        public static Logger CreateLogger(string type, string filePath = null)
        {
            return type switch
            {
                "Console" => new Logger(),
                "File" when filePath != null => new FileLog(new FileWriter(filePath)),
                _ => throw new ArgumentException("Invalid logger type or missing file path for file logger.")
            };
        }
    }
}
