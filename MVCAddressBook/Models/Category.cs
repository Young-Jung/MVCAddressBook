using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public byte[] Profile { get; set; }
        public string ContentType { get; set; }

        public ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    }
}
