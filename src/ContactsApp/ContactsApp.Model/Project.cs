using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary> 
    /// Описывает проект. 
    /// </summary> 
    internal class Project
    {
        /// <summary> 
        /// Контакты. 
        /// </summary> 
        private SortedSet<Contact> contacts = new SortedSet<Contact> ();

        /// <summary> 
        /// Возвращает именинников. 
        /// </summary> 
        public SortedSet<Contact> GetBirthdays()
        {
            SortedSet<Contact> birthdays = new SortedSet<Contact> ();
            foreach (Contact contact in contacts)
            {
                if (contact.DateOfBirth.CompareTo(DateTime.Today) == 0)
                    birthdays.Add(contact);
            }
            return birthdays;
        }

        /// <summary> 
        /// Возвращает найденные по подстроке контакты. 
        /// </summary> 
        public SortedSet<Contact> FindContacts(string subStr)
        {
            SortedSet<Contact> findedContacts = new SortedSet<Contact>();
            foreach (Contact contact in contacts)
            {
                if (contact.DateOfBirth.ToString().Contains(subStr))
                    findedContacts.Add(contact);
                else if (contact.FullName.Contains(subStr))
                    findedContacts.Add(contact);
                else if (contact.Email.Contains(subStr))
                    findedContacts.Add(contact);
                else if (contact.PhoneNumber.Contains(subStr))
                    findedContacts.Add(contact);
                else if (contact.VkID.Contains(subStr))
                    findedContacts.Add(contact);
            }
            return findedContacts;
        }
    }
}
