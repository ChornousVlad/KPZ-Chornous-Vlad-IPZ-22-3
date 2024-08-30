using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Shape
    {
        protected IProcessingModule renderer;

        public Shape(IProcessingModule renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }
}
