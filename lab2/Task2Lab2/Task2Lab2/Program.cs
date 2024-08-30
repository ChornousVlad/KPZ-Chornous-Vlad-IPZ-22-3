using Task2Lab2;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

IAbstractFactory[] factories = new IAbstractFactory[]
            {
                new Dell(),
                new Asus(),
                new Apple()
            };

Console.WriteLine("Створення ноутбуків:");
foreach (var factory in factories)
{
    IAbstractLaptop laptop = factory.CreateLaptop();
    Console.WriteLine(laptop.LaptopCreation());
}

Console.WriteLine("\nСтворення смартфонів:");
foreach (var factory in factories)
{
    IAbstractSmartphone smartphone = factory.CreateSmartphone();
    Console.WriteLine(smartphone.SmartphoneCreation());
}

Console.WriteLine("\nСтворення нетбуків:");
foreach (var factory in factories)
{
    IAbstractNetBook netbook = factory.CreateNetBook();
    Console.WriteLine(netbook.NetbookCreation());
}

Console.ReadLine();