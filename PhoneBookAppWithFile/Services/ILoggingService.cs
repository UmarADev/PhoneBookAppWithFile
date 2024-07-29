namespace PhoneBookAppWithFile.Services
{
    internal interface ILoggingService
    {
        void LogError(string message);
        void LogInformation(string message);
        void LogMenu();
    }
}