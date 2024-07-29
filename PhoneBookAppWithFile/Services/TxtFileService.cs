using PhoneBookAppWithFile.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhoneBookAppWithFile.Services
{
    internal class TxtFileService : IFileService
    {
        private ILoggingService loggingService;
        private const string filePath = "../../../Contacts.txt";

        public TxtFileService()
        {
            this.loggingService = new LoggingService();
            CreateFileIfNotExists();
        }

        public Contact AddContact(Contact contact)
        {
            File.AppendAllText(filePath, contact.Name + "\t: " + contact.PhoneNumber + Environment.NewLine);
            return contact;
        }

        public bool DeleteContact(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<Contact> ReadAllContacts()
        {
            throw new NotImplementedException();
        }

        private void CreateFileIfNotExists()
        {
            var isFileExists = File.Exists(filePath);

            if (isFileExists is false)
            {
                File.Create(filePath).Close();
            }
        }
    }
}
