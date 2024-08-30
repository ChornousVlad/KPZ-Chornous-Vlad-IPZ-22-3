using Task1;

class Program
{
    static void Main()
    {
        Logger consoleLogger = CreationLog.CreateLogger("Console");
        consoleLogger.Log("This is a log message.");
        consoleLogger.Error("This is an error message.");
        consoleLogger.Warn("This is a warning message.");

        Logger fileLogger = CreationLog.CreateLogger("File", "log.txt");
        fileLogger.Log("This is a log message.");
        fileLogger.Error("This is an error message.");
        fileLogger.Warn("This is a warning message.");

        Console.WriteLine("Logging complete. Check the log file for file logger output.");
    }
}
