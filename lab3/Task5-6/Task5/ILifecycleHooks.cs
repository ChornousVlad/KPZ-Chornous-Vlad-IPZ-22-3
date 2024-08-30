using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public interface ILifecycleHooks
    {
        void OnCreated();
        void OnInserted();
        void OnRemoved();
        void OnStylesApplied();
        void OnClassListApplied();
        void OnTextRendered();
    }
}
