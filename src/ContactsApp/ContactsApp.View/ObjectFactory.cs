using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContactsApp.View
{
    static public class ObjectFactory
    {   private static Random random = new Random();
        private static List<string> _names = new List<string> { "Максим", "Иван", "Антон", "Дмитрий", "Петр" };
        private static List<string> _surnames = new List<string> { "Иванов", "Кузнецов", "Петров", "Волков", "Васильев" };
        private static List<string> _alphabet = new List<string>();
        public static string GetFullName()
        {
            string fullName = _names[random.Next(_names.Count)] + " ";
            fullName += _surnames[random.Next(_surnames.Count)];
            return fullName;
        }
        public static string GetEmail()
        {
            string email = "";
            int emailSize = random.Next(50);
            for(int i = 0; i < emailSize; i++)
            {
                email+=(_alphabet[random.Next(_alphabet.Count)]);
            }
            email += "@";
            int prefixSize = random.Next(10);
            for (int i = 0; i < prefixSize; i++)
            {
                email += (_alphabet[random.Next(_alphabet.Count)]);
            }
            email += ".";
            int postfixSize = random.Next(5);
            for (int i = 0; i < postfixSize; i++)
            {
                email += (_alphabet[random.Next(_alphabet.Count)]);
            }
            return email;
        }
        static public string GetPhoneNumber()
        {
            string number = "+";
            for (int i = 0; i < 10; i++)
                number += random.Next(10);
            return number;
        }
        static public string GetVkID()
        {
            string id = "";
            int idSize = random.Next(50);
            for (int i = 0; i < idSize; i++)
            {
                id += (_alphabet[random.Next(_alphabet.Count)]);
            }
            return id;
        }
        static public DateTime GetDateOfBirth()
        {
            DateTime dateTime = new DateTime(1950 + random.Next(72), random.Next(12) + 1, random.Next(27) + 1);
            return dateTime;
        }
        static ObjectFactory()
        {
            for (char c = 'A'; c <= 'Z'; ++c)
            {
                _alphabet.Add(c.ToString());
            }
        }
    }
}
