using PhoneBookAppWithFile.Services;
using System;

namespace PhoneBookAppWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileService fileService = new FileService();

            Console.ReadLine();
        }
    }
}
