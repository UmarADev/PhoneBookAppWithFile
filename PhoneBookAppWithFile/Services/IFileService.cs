using PhoneBookAppWithFile.Models;
using System.Collections.Generic;

namespace PhoneBookAppWithFile.Services
{
    internal interface IFileService
    {
        Contact AddContact(Contact contact);
        bool DeleteContact(string phoneNumber);
        List<Contact> ReadAllContacts();
    }
}