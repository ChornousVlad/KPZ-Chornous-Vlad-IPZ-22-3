namespace Task1
{
    public class FileLog : Logger
    {
        private readonly FileWriter _fileWriter;

        public FileLog(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public override void Log(string message)
        {
            base.Log(message); 
            _fileWriter.WriteLine($"LOG: {message}");  
        }

        public override void Error(string message)
        {
            base.Error(message);
            _fileWriter.WriteLine($"ERROR: {message}");
        }

        public override void Warn(string message)
        {
            base.Warn(message);
            _fileWriter.WriteLine($"WARN: {message}");
        }
    }
}
