

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var root = new LightElementNode("html");
            var head = new LightElementNode("head");
            var body = new LightElementNode("body");

            root.AddChild(head);
            root.AddChild(body);

            var title = new LightElementNode("title");
            var h1 = new LightElementNode("h1");
            var p1 = new LightTextNode("This is a paragraph.");
            var p2 = new LightTextNode("Another paragraph here.");

            head.AddChild(title);
            body.AddChild(h1);
            body.AddChild(p1);
            body.AddChild(p2);

            
            Console.WriteLine("HTML Document:");
            Console.WriteLine(root.OuterHTML);

            // Завдання 6
            string text = File.ReadAllText("book.txt");
            var htmlRoot = ConvertTextToHtml(text);

            Console.WriteLine("\nConverted HTML:");
            Console.WriteLine(htmlRoot.OuterHTML);

         
            var process = System.Diagnostics.Process.GetCurrentProcess();
            Console.WriteLine($"Memory Usage: {process.WorkingSet64 / 1024} KB");
        }

        static LightElementNode ConvertTextToHtml(string text)
        {
            var lines = text.Split('\n');
            var root = new LightElementNode("div");

            foreach (var line in lines)
            {
                LightElementNode element;
                if (line.Length < 20)
                {
                    element = new LightElementNode("h2");
                }
                else if (line.StartsWith(" "))
                {
                    element = new LightElementNode("blockquote");
                }
                else
                {
                    element = new LightElementNode("p");
                }

                element.AddChild(new LightTextNode(line));
                root.AddChild(element);
            }

            return root;
        }
    }
}
