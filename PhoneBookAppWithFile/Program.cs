using PhoneBookAppWithFile.Models;
using PhoneBookAppWithFile.Services;
using System;

namespace PhoneBookAppWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileService fileService = new JsonFileService();
            ILoggingService loggingService = new LoggingService();

            while (true)
            {
                Console.Clear();
                loggingService.LogMenu();
                Console.Write("Enter: ");
                var option = Console.ReadLine();

                if (option == "1")
                {
                    var contact = new Contact();
                    loggingService.LogInformation("Enter name: ");
                    contact.Name = Console.ReadLine();
                    loggingService.LogInformation("Enter phone number: ");
                    contact.PhoneNumber = Console.ReadLine();
                    fileService.AddContact(contact);
                }
                else if (option == "2")
                {
                    loggingService.LogInformation("Enter phone number to delete: ");
                    var phoneNumber = Console.ReadLine();

                    var result = fileService.DeleteContact(phoneNumber);

                    if (result is true)
                    {
                        loggingService.LogInformation("Successfully deleted");
                    }
                    else
                    {
                        loggingService.LogInformation("There is no contact");
                    }

                }
                else if (option == "3")
                {
                    var contacts = fileService.ReadAllContacts();
                    foreach (var contact in contacts)
                    {
                        loggingService.LogInformation(contact.Name + " " + contact.PhoneNumber);
                    }
                }
                else if (option == "4")
                {
                    loggingService.LogInformation("Thanks for using our app");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
