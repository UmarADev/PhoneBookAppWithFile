using PhoneBookAppWithFile.Services;
using System;

namespace PhoneBookAppWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileService fileService = new JsonFileService();

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            fileService.CreateName(name);
        }
    }
}
