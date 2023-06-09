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
                if (value.Length == 0)
                {
                    throw new ArgumentException("Имя должно быть задано");
                }
                if (value.Length > 100)
                {
                    throw new ArgumentException("Имя должно быть короче 50 символов");
                }
                CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                _fullName =currentCulture.TextInfo.ToTitleCase(value);
            }
        }

        /// <summary> 
        /// Возвращает или задает телефонный номер. 
        /// </summary> 
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set {

                if (value.Length != 17)
                {
                    throw new ArgumentException("Длина номера телефона должна быть равна 17 символам");
                }
                if ((!value.All(c => "1234567890+-() ".Contains(c))))
                {
                    throw new ArgumentException("Недопустимые символы в номере телефона");
                }
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
                {
                    throw new ArgumentException("Длина адреса электронной почты должна быть меньше 50 символов");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("Адрес электронной почты должен быть задан");
                }
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
                {
                    throw new ArgumentException("Дата рождения должна быть позднее 1900 года");
                }
                if (value.CompareTo(DateTime.Now) >= 0)
                {
                    throw new ArgumentException("Дата рождения не может быть в будущем");
                }
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
                if (value.Length > 50 )
                {
                    throw new ArgumentException("ID ВКонтакте должен быть меньше 50 символов");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("ID ВКонтакте должен быть задан");
                }
                _vkID = value; 
            }
        }

        /// <summary> 
        /// Создает пустой экземпляр <see cref="Contact"/>. 
        /// </summary> 
        public Contact() { }

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
            if (contact == null)
            { 
                throw new ArgumentNullException("Contact is null"); 
            }
            return FullName.CompareTo(contact.FullName);
        }
    }
}
