using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ImageNode : LightNode
    {
        public string Href { get; set; }
        public bool IsLoaded { get; private set; }

        public ImageNode(string href)
        {
            Href = href;
            IsLoaded = false;
        }

        public override string OuterHTML => $"<img src=\"{Href}\" />";

        public override string InnerHTML => throw new NotImplementedException();

        public void LoadImage()
        {
            if (Href.StartsWith("http") || Href.StartsWith("https"))
            {
                Console.WriteLine($"Loading image from network: {Href}");
            }
            else
            {
                Console.WriteLine($"Loading image from file system: {Href}");
            }

            IsLoaded = true;
        }
    }
}
