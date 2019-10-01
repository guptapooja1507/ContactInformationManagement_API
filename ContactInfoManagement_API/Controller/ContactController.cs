using ContactInfoManagement_API.BusinessLayer.Interface;
using ContactInfoManagement_API.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Routing;

namespace ContactInfoManagement_API.Controller
{
    [RoutePrefix("api/[Controller]")]
    public class ContactController : ApiController
    {
        private IContactManager _contactManager;

        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }

        // GET: api/contact/GetContactDetails
        [HttpGet]
        [Route("~/GetContactDetails")]
        public IHttpActionResult GetContactList()
        {
            IEnumerable<Contact> contactList = _contactManager.GetAllContactDeatils();
            if (contactList != null)
                return Ok(contactList);

            return NotFound();
        }

        // Post: api/contact/AddContactDetail
        [HttpPost]
        [Route("~/AddContactDetail")]
        public IHttpActionResult AddContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bool status = _contactManager.AddContact(contact);

            return CreatedAtRoute("DefaultApi", new { id = contact.Id }, contact);
        }

        // Put: api/contact/EditContactDetail
        [HttpPut]
        [Route("~/EditContactDetail/{contactID}")]
        public IHttpActionResult EditContact(int contactID, Contact contact)
        {
            bool status = _contactManager.EditContact(contactID, contact);
            if (status)
                return Ok(status);

            return NotFound();
        }

        // Put: api/contact/DeleteContactDetail
        [HttpDelete]
        [Route("~/DeleteContactDetail/{contactID}")]
        public IHttpActionResult DeleteContact(int contactID)
        {
            bool status = _contactManager.DeleteInactiveContact(contactID);
            if (status)
                return Ok(status);

            return NotFound();
        }
    }
}
