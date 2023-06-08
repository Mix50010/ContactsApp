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
        public List<Contact> GetContactsByDateOfBirth(DateTime date)
        {
            List<Contact> birthdays = new List<Contact> ();
            foreach (Contact contact in _contacts)
            {
                if (contact.DateOfBirth.Month == date.Month && 
                    contact.DateOfBirth.Day == date.Day )
                {
                    birthdays.Add(contact);
                }
            }
            return birthdays;
        }

        /// <summary> 
        /// Возвращает найденные по подстроке контакты. 
        /// </summary> 
        public List<Contact> FindContacts(string subString)
        {
            List<Contact> findedContacts = new List<Contact>();
            foreach (Contact contact in _contacts)
            {
                if (contact.DateOfBirth.ToString().Contains(subString) ||
                        contact.FullName.Contains(subString) ||
                        contact.Email.Contains(subString) ||
                        contact.PhoneNumber.Contains(subString) ||
                        contact.VkID.Contains(subString))
                {
                    findedContacts.Add(contact);
                }
            }
            return findedContacts;
        }
    }
}
