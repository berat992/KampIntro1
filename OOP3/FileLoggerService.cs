namespace OOP3
{
    internal class FileLoggerService : ILoggerService // Metin dosyasına loglama ( kayıt alma
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
