using lab1;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
Dollar dollar = new Dollar("Крипта", 10, 50);
Euro euro = new Euro("Словаччина", 20, 75);
Hryvnia hryvnia = new Hryvnia(true, 500, 30);

Console.WriteLine("Гроші:");
Console.WriteLine(dollar);
Console.WriteLine(euro);
Console.WriteLine(hryvnia);

dollar.setWholePArt(15);
euro.setCoinPart(80);
hryvnia.setForgery(false);

Console.WriteLine("\nОновлені гроші:");
Console.WriteLine(dollar);
Console.WriteLine(euro);
Console.WriteLine(hryvnia);

Product product1 = new Product(dollar, "Електроніка");
product1.setCategory("Electronics");

Product product2 = new Product(euro, "Одяг");
product2.setCategory("Clothing");

Console.WriteLine("\nТовари:");
Console.WriteLine(product1);
Console.WriteLine(product2);

Warehouse warehouse1 = new Warehouse("Телефон", "pieces", product1, 100, DateTime.Now, product1);
Warehouse warehouse2 = new Warehouse("Рубашка", "items", product2, 50, DateTime.Now, product2);

Console.WriteLine("\nІнформація про склад:");
Console.WriteLine(warehouse1);
Console.WriteLine(warehouse2);

Reporting reporting = new Reporting();
reporting.RegisterIncomingGoods(warehouse1);
reporting.RegisterIncomingGoods(warehouse2);
Console.WriteLine("-------------------------------------------------");
reporting.GenerateIncomingReport();

Warehouse itemToSend = warehouse1;
reporting.RegisterOutgoingGoods(itemToSend);
Console.WriteLine("-------------------------------------------------");
reporting.GenerateOutgoingReport();
Console.WriteLine("-------------------------------------------------");
reporting.GenerateInventoryReport();