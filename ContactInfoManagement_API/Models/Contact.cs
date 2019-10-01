using ContactInfoManagement_API.Enum;

namespace ContactInfoManagement_API.Models
{
    public class Contact
    {
        /// <summary>
        /// Get or sets id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or sets first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Get or sets last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Get or sets email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Get or sets phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Get or sets status.
        /// </summary>
        public ContactStatus Status { get; set; }
    }
}