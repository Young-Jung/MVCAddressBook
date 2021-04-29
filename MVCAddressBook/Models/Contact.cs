using MVCAddressBook.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        //public string State { get; set; }
        public States State { get; set; }
        public string ZipCode { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
