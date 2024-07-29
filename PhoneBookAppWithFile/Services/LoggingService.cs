using System;

namespace PhoneBookAppWithFile.Services
{
    internal class LoggingService : ILoggingService
    {
        public void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }

        public void LogMenu()
        {
            LogInformation("What do you want to do?");
            LogInformation("1. Add a contact");
            LogInformation("2. Remove a contact");
            LogInformation("3. Show all contacts");
            LogInformation("4. Exit ");
        }
    }
}
