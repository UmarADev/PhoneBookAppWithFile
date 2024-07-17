using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
