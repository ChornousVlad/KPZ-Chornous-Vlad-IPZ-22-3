using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PixelProcessingModule : IProcessingModule
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as pixels");
        }
    }
}
