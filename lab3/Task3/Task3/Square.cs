using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Square : Shape
    {
        public Square(IProcessingModule renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Square");
        }
    }
}
