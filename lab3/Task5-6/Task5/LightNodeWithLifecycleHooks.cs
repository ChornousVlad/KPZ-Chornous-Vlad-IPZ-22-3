using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class LightNodeWithLifecycleHooks : LightNode, ILifecycleHooks
    {
        public override string OuterHTML
        {
            get
            {
                ApplyStyles();
                ApplyClassList();
                OnStylesApplied();
                OnClassListApplied();
                return "";
            }
        }

        public override string InnerHTML
        {
            get
            {
                RenderText();
                OnTextRendered();
                return "";
            }
        }

        public void OnCreated()
        {
            Console.WriteLine("Element created.");
        }

        public void OnInserted()
        {
            Console.WriteLine("Element inserted into DOM.");
        }

        public void OnRemoved()
        {
            Console.WriteLine("Element removed from DOM.");
        }

        public void OnStylesApplied()
        {
            Console.WriteLine("Styles applied to element.");
        }

        public void OnClassListApplied()
        {
            Console.WriteLine("Class list applied to element.");
        }

        public void OnTextRendered()
        {
            Console.WriteLine("Text rendered inside element.");
        }

        protected abstract void ApplyStyles();
        protected abstract void ApplyClassList();
        protected abstract void RenderText();
    }
}
