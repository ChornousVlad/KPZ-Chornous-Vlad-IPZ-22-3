using Task4;

class Program
{
    static void Main()
    {
        string filePath = "test.txt";

        SmartTextReader reader = new SmartTextReader();
        SmartTextChecker checker = new SmartTextChecker(reader);
        SmartTextReaderLocker locker = new SmartTextReaderLocker(reader, @"^.*\.restricted$");

        Console.WriteLine("Using SmartTextChecker:");
        char[][] checkedContent = checker.ReadFile(filePath);

        Console.WriteLine("Content read by SmartTextChecker:");
        foreach (var line in checkedContent)
        {
            Console.WriteLine(new string(line));
        }

        Console.WriteLine("Using SmartTextReaderLocker:");
        char[][] lockedContent = locker.ReadFile(filePath);

        if (lockedContent.Length > 0)
        {
            Console.WriteLine("Content read by SmartTextReaderLocker:");
            foreach (var line in lockedContent)
            {
                Console.WriteLine(new string(line));
            }
        }
    }
}