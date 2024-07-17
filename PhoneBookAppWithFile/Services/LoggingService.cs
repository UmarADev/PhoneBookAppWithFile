using System;

namespace PhoneBookAppWithFile.Services
{
    internal class LoggingService : ILoggingService
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }
    }
}
