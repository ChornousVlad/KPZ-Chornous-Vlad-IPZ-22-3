using lab2Task1;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Source[] sources = new Source[]
            {
                new ManagerCall(),
                new WebSite(),
                new MobileApp()
            };

foreach (var source in sources)
{
    Console.WriteLine(source.Subscribe());
    Console.WriteLine();
}

Console.ReadLine();