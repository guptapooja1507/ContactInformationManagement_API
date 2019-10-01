using ContactInfoManagement_API.DataAccessLayer.Interface;
using ContactInfoManagement_API.Enum;
using ContactInfoManagement_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactInfoManagement_API.DataAccessLayer.Implementation
{
    public class ContactRepository : IContactRepository
    {
        /// <summary>
        /// This method is used to get all contact details.
        /// </summary>
        /// <returns>List of cintact.</returns>
        public IEnumerable<Contact> GetAllContactDeatils()
        {
            return ContactContext.ContactList;
        }

        /// <summary>
        /// This method is used to add the contact.
        /// </summary>
        /// <param name="contact">New contact</param>
        /// <returns>No. of row affected.</returns>
        public bool AddContact(Contact contact)
        {
            int contactCount = ContactContext.ContactList.Count();
            ContactContext.ContactList.Add(contact);

            return ContactContext.ContactList.Count() > contactCount ? true : false;
        }

        /// <summary>
        /// This method is used to add the contact.
        /// </summary>
        /// <param name="id">contact id.</param>
        /// <param name="contact">contact object</param>
        /// <returns>No. of row affected.</returns>
        public bool EditContact(int id, Contact contact)
        {
            if (ContactContext.ContactList.Remove(ContactContext.ContactList.Find(con => con.Id == id)))
            {
                ContactContext.ContactList.Add(contact);
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// this method is used to delete inactive contact.
        /// </summary>
        /// <param name="id">contact id.</param>
        /// <returns>Boolean value</returns>
        public bool DeleteInactiveContact(int id)
        {
            Contact contact = ContactContext.ContactList.Find(con => con.Id == id);
            if (contact.Status == ContactStatus.Inactive)
                return ContactContext.ContactList.Remove(contact);
            else
                return false;
        }
    }
}