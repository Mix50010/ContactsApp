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
    public class Project
    {
        /// <summary> 
        /// Контакты. 
        /// </summary> 
        private List<Contact> _contacts = new List<Contact> ();

        /// <summary> 
        /// Возвращает и задает контакты. 
        /// </summary>
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }
        /// <summary>  
        /// Возвращает именинников. 
        /// </summary> 
        public List<Contact> GetBirthdays()
        {
            List<Contact> birthdays = new List<Contact> ();
            foreach (Contact contact in _contacts)
            {
                if (contact.DateOfBirth.Date.CompareTo(DateTime.Now.Date) == 0)
                    birthdays.Add(contact);
            }
            return birthdays;
        }

        /// <summary> 
        /// Возвращает найденные по подстроке контакты. 
        /// </summary> 
        public List<Contact> FindContacts(string subStr)
        {
            List<Contact> findedContacts = new List<Contact>();
            foreach (Contact contact in _contacts)
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
