using PhoneBookAppWithFile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

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
            File.AppendAllText(filePath, contact.Name + " " + contact.PhoneNumber + Environment.NewLine);
            return contact;
        }

        public bool DeleteContact(string phoneNumber)
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();

            if (filePath.Contains(phoneNumber) == true)
            {
                List<string> txtFile = File.ReadAllLines(filePath).ToList();

                string deleteTxtFileObject = name + phoneNumber;

                txtFile.Remove(deleteTxtFileObject);

                File.WriteAllLines(filePath, txtFile);

                loggingService.LogInformation("Succesfully deleted!");
            }
            return true;
        }

        public List<Contact> ReadAllContacts()
        {
            List<Contact> phoneContacts = new List<Contact>();

            string[] allLines = File.ReadAllLines(filePath);

            foreach (string line in allLines)
            {
                var contact = new Contact();
                string[] words = line.Split(" ");

                contact.Name = words[0];
                contact.PhoneNumber = words[1];

                phoneContacts.Add(contact);
            }

            return phoneContacts;
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
