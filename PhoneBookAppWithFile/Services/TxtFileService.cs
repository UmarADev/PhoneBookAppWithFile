using PhoneBookAppWithFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
