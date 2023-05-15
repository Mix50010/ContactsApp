using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContactsApp.View
{
    /// <summary> 
    /// Фабрика экземпляров объектов. 
    /// </summary> 
    static public class ObjectFactory
    {    /// <summary> 
         /// Экземпляр рандома. 
         /// </summary> 
        private static Random random = new Random();

        /// <summary> 
        /// Возможные имена. 
        /// </summary> 
        private static List<string> _names = new List<string> { "Максим", "Иван", "Антон", "Дмитрий", "Петр" };

        /// <summary> 
        /// Возможные фамилии. 
        /// </summary> 
        private static List<string> _surnames = new List<string> { "Иванов", "Кузнецов", "Петров", "Волков", "Васильев" };

        /// <summary> 
        /// Алфавит. 
        /// </summary> 
        private static List<string> _alphabet = new List<string>();

        /// <summary> 
        /// Возвращает случаное полное имя. 
        /// </summary> 
        public static string GetFullName()
        {
            string fullName = _names[random.Next(_names.Count)] + " ";
            fullName += _surnames[random.Next(_surnames.Count)];
            return fullName;
        }

        /// <summary> 
        /// Возвращает случайный адрес почты. 
        /// </summary> 
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

        /// <summary> 
        /// Возвращает случайный номер. 
        /// </summary> 
        static public string GetPhoneNumber()
        {
            string number = "+7 (";
            for (int i = 0; i < 3; i++)
                number += random.Next(10);
            number += ") ";
            for (int i = 0; i < 3; i++)
                number += random.Next(10);
            number += "-";
            for (int i = 0; i < 4; i++)
                number += random.Next(10);
            return number;
        }

        /// <summary> 
        /// Возвращает случайный ВкАйди. 
        /// </summary> 
        static public string GetVkID()
        {
            string id = "";
            int idSize = random.Next(50) + 1;
            for (int i = 0; i < idSize; i++)
            {
                id += (_alphabet[random.Next(_alphabet.Count)]);
            }
            return id;
        }

        /// <summary> 
        /// Возвращает случайную дату рождения. 
        /// </summary> 
        static public DateTime GetDateOfBirth()
        {
            DateTime dateTime = new DateTime(1950 + random.Next(72), random.Next(12) + 1, random.Next(27) + 1);
            return dateTime;
        }

        /// <summary> 
        /// Инициализирует алфавит. 
        /// </summary> 
        static ObjectFactory()
        {
            for (char c = 'A'; c <= 'Z'; ++c)
            {
                _alphabet.Add(c.ToString());
            }
        }
    }
}
