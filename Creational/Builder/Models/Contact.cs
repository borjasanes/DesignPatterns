using System;

namespace Creational.Builder.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public bool PhoneConfirmed { get; set; }
    }
}
