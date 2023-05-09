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
    internal class Contact : ICloneable, IComparable<Contact>
    {
        private string fullName;
        public string FullName
        {
            get { return FullName; }
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("FullName length should be less than 50 symbols");
                CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                fullName =currentCulture.TextInfo.ToTitleCase(value);

                string v = String.Join(" ", value.Split().Select(s => s.First().ToString().ToUpper()));
                fullName = v;
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set {
                if (value.Length != 11 || value.All(c => "1234567890+-() ".Contains(c)))
                    throw new ArgumentException("PhoneNumber length should be equal to 11 symbols " +
                        "and contains only digits and '+' symbol");
                phoneNumber = value;
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set {
                if (value.Length > 100)
                    throw new ArgumentException("Email length should be less than 50 symbols"); 
                email = value; 
            }
        }
        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set {
                if (value.Year > 1900 || value.CompareTo(DateTime.Now) >= 0)
                    throw new ArgumentException("DateTime should be more than 1900 and less than now");
                dateOfBirth = value;
            }
        }
        private string vkID;
        public string VkID
        {
            get { return vkID; }
            set {
                if (value.Length > 50)
                    throw new ArgumentException("VK ID length should be less than 50 symbols");
                vkID = value; 
            }
        }
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
        public object Clone()
        {
            return new Contact(FullName, PhoneNumber, Email, DateOfBirth, VkID);
        }
        public int CompareTo(Contact contact)
        {
            if (contact == null) throw new ArgumentNullException("Contact is null");
            return FullName.CompareTo(contact.FullName);
        }
    }
}
