using System;
using Creational.Builder.Models;

namespace Creational.Builder
{
    /// <summary>
    /// Separate the construction of a complex object from its representation
    /// so that the same construction process can create different representations.
    /// </summary>
    public class ContactBuilder
    {
        private static DateTime Birthday { get; set; }
        private static string Phone { get; set; }
        private static bool PhoneConfirmed { get; set; }
        private static string Name { get; set; }

        public static ContactBuilder AContactBuilder()
        {
            return new ContactBuilder();
        }

        public ContactBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public ContactBuilder WithPhone(string phone)
        {
            Phone = phone;
            return this;
        }

        public ContactBuilder WithPhoneConfirmed(bool phoneConfirmed)
        {
            PhoneConfirmed = phoneConfirmed;
            return this;
        }

        public ContactBuilder WithBirthday(DateTime birthday)
        {
            Birthday = birthday;
            return this;
        }


        public Contact Build()
        {
            return new Contact
            {
                PhoneConfirmed = PhoneConfirmed,
                BirthDate = Birthday,
                Name = Name,
                Phone = Phone
            };
        }
    }
}