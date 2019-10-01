using ContactInfoManagement_API.BusinessLayer.Interface;
using ContactInfoManagement_API.DataAccessLayer.Interface;
using ContactInfoManagement_API.Models;
using System.Collections.Generic;

namespace ContactInfoManagement_API.BusinessLayer.Implementation
{
    public class ContactManager : IContactManager
    {
        private IContactRepository _contactRepository;
        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        /// <summary>
        /// This method is used to get all contact details.
        /// </summary>
        /// <returns>List of cintact.</returns>
        public IEnumerable<Contact> GetAllContactDeatils()
        {
            return _contactRepository.GetAllContactDeatils();
        }

        /// <summary>
        /// This method is used to add the contact.
        /// </summary>
        /// <param name="contact">New contact</param>
        /// <returns>No. of row affected.</returns>
        public bool AddContact(Contact contact)
        {
            return _contactRepository.AddContact(contact);
        }

        /// <summary>
        /// This method is used to add the contact.
        /// </summary>
        /// <param name="id">contact id.</param>
        /// <param name="contact">contact object</param>
        /// <returns>No. of row affected.</returns>
        public bool EditContact(int id, Contact contact)
        {
            return _contactRepository.EditContact(id, contact);
        }

        /// <summary>
        /// this method is used to delete inactive contact.
        /// </summary>
        /// <param name="id">contact id.</param>
        /// <returns>Boolean value</returns>
        public bool DeleteInactiveContact(int id)
        {
            return _contactRepository.DeleteInactiveContact(id);
        }
    }
}