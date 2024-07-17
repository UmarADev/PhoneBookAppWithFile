using System.IO;

namespace PhoneBookAppWithFile.Services
{
    internal class FileService : IFileService 
    {
        private ILoggingService loggingService;
        private const string filePath = "../../../phoneBook.txt";

        public FileService()
        {
            this.loggingService = new LoggingService();

            EnsureFileExists();
        }

        private static void EnsureFileExists()
        {
            bool isFilePresent = File.Exists(filePath);

            if (isFilePresent is false)
            {
                File.Create(filePath).Close();
            }
        }

        public string CreateName(string name)
        {
            File.AppendAllText(filePath, name);

            return name;
        }
    }
}
