using ContactInfoManagement_API.Enum;
using ContactInfoManagement_API.Models;
using System.Collections.Generic;

namespace ContactInfoManagement_API.DataAccessLayer
{
    /// <summary>
    /// This class is used to generate moq data for contact.
    /// </summary>
    public class ContactContext
    {
        public static List<Contact> ContactList;

        static ContactContext()
        {
            ContactList = CreateContactList();
        }
        private static List<Contact> CreateContactList()
        {
            return new List<Contact>
            {
                new Contact
                {
                    Id = 1,
                    FirstName = "Alfreds",
                    LastName = "Futterkiste",
                    Email = "alfreds.futterkiste@gmail.com",
                    PhoneNumber = "030-0074321",
                    Status = ContactStatus.Active
                },
                new Contact
                {
                    Id = 2,
                    FirstName = "Alex",
                    LastName = "Emparedados",
                    Email = "alex.emparedados@gmail.com",
                    PhoneNumber = "030-0074322",
                    Status = ContactStatus.Active
                },
                new Contact
                {
                    Id = 3,
                    FirstName = "Moreno",
                    LastName = "Taquería",
                    Email = "moreno.taquería@gmail.com",
                    PhoneNumber = "030-0074341",
                    Status = ContactStatus.Inactive
                }
            };
        }
    }
}