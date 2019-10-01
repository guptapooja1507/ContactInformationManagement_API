using ContactInfoManagement_API.Models;
using System.Collections.Generic;

namespace ContactInfoManagement_API.BusinessLayer.Interface
{
    public interface IContactManager
    {
        /// <summary>
        /// This method is used to get all contact details.
        /// </summary>
        /// <returns>List of cintact.</returns>
        IEnumerable<Contact> GetAllContactDeatils();

        /// <summary>
        /// This method is used to add the contact.
        /// </summary>
        /// <param name="contact">New contact</param>
        /// <returns>No. of row affected.</returns>
        bool AddContact(Contact contact);

        /// <summary>
        /// This method is used to add the contact.
        /// </summary>
        /// <param name="id">contact id.</param>
        /// <param name="contact">contact object</param>
        /// <returns>No. of row affected.</returns>
        bool EditContact(int id, Contact contact);

        /// <summary>
        /// this method is used to delete inactive contact.
        /// </summary>
        /// <param name="id">contact id.</param>
        /// <returns></returns>
        bool DeleteInactiveContact(int id);
    }
}
