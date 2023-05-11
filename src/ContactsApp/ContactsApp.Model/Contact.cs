using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Globalization;

namespace ContactsApp.Model
{
    /// <summary> 
    /// Описывает контакт. 
    /// </summary> 
    public class Contact : ICloneable, IComparable<Contact>
    {
        /// <summary> 
        /// Полное имя. 
        /// </summary> 
        private string _fullName;

        /// <summary> 
        /// Телефонный номер. 
        /// </summary> 
        private string _phoneNumber;

        /// <summary> 
        /// Адрес электронной почты. 
        /// </summary> 
        private string _email;

        /// <summary> 
        /// Дата рождения. 
        /// </summary> 
        private DateTime _dateOfBirth;

        /// <summary> 
        /// Идентификатор ВКонтакте. 
        /// </summary> 
        private string _vkID;

        /// <summary> 
        /// Возвращает или задает полное имя. 
        /// </summary> 
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("FullName length should be less than 50 symbols");
                CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                _fullName =currentCulture.TextInfo.ToTitleCase(value);

               // string v = String.Join(" ", value.Split().Select(s => s.First().ToString().ToUpper()));
               // _fullName = v;
            }
        }

        /// <summary> 
        /// Возвращает или задает телефонный номер. 
        /// </summary> 
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set {
                if (value.Length != 11)
                    throw new ArgumentException("PhoneNumber length should be equal to 11 symbols " +
                        "and contains only digits and '+' symbol");
                if ((!value.All(c => "1234567890+-() ".Contains(c))))
                    throw new ArgumentException("PhoneNumber length should contain only digits and '+' symbol");
                _phoneNumber = value;
            }
        }

        /// <summary> 
        /// Возвращает или задает электронный адрес. 
        /// </summary> 
        public string Email
        {
            get { return _email; }
            set {
                if (value.Length > 100)
                    throw new ArgumentException("Email length should be less than 50 symbols"); 
                _email = value; 
            }
        }

        /// <summary> 
        /// Возвращает или задает дату рождения. 
        /// </summary> 
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set {
                if (value.Year < 1900)
                    throw new ArgumentException("DateTime should be more than 1900");
                if (value.CompareTo(DateTime.Now) >= 0)
                    throw new ArgumentException("DateTime should be less than now");
                _dateOfBirth = value;
            }
        }

        /// <summary> 
        /// Возвращает или задает идентификатор ВКонтакте. 
        /// </summary> 
        public string VkID
        {
            get { return _vkID; }
            set {
                if (value.Length > 50)
                    throw new ArgumentException("VK ID length should be less than 50 symbols");
                   _vkID = value; 
            }
        }

        /// <summary> 
        /// Создает экземпляр <see cref="Contact"/>. 
        /// </summary> 
        public Contact(string fullName,
            string phoneNumber,
            string email,
            DateTime dateOfBirth,
            string vkID)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            DateOfBirth = dateOfBirth;
            VkID = vkID;
        }

        /// <summary> 
        /// Реализация ICloneable. 
        /// </summary> 
        public object Clone()
        {
            return new Contact(FullName, PhoneNumber, Email, DateOfBirth, VkID);
        }

        /// <summary> 
        /// Реализация IComparable. 
        /// </summary> 
        public int CompareTo(Contact contact)
        {
            if (contact == null) throw new ArgumentNullException("Contact is null");
            return FullName.CompareTo(contact.FullName);
        }
    }
}
