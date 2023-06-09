using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp.Model;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        [Test(Description = "Позитивный сет геттера FullName")]
        public void TestFullNameGet_CorrectValue()
        {
            //Arrange
            var expected = "Смирнов Михаил";
            var contact = new Contact();

            //Act
            contact.FullName = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер FullName возвращает неверную фамилию");
        }

        [TestCase("", "Должно возникать исключение, если имя пустое", 
            TestName = "Присвоение пустой строки в полное имя")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов\" +\r\n                \"Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов\" +\r\n                \"Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если имя слишком длинное",
            TestName = "Присвоение слишком длинной  строки в полное имя")]
        public void TestFullNameSet_ArgumentException(string wrongFullName, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert & Act
            Assert.Throws<ArgumentException>(() => contact.FullName = wrongFullName,
                message);
        }

        [Test(Description = "Позитивный сет геттера PhoneNumber")]
        public void TestPhoneNumberGet_CorrectValue()
        {
            //Arrange
            var expected = "+7 (923) 444-1226";
            var contact = new Contact();

            //Act
            contact.PhoneNumber = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер PhoneNumber возвращает неверную фамилию");
        }

        [TestCase("+7 (923) 123-", "Должно возникать исключение, если длина строки номера не соотвутствует 17 символам",
            TestName = "Присвоение  строки неверной длины в номер")]
        [TestCase("HelloWorld1234567", "Должно возникать исключение, если номер содержит буквы",
            TestName = "Присвоение букв в номер")]
        public void TestPhoneNumberSet_ArgumentException(string wrongPhoneNumber, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() => contact.PhoneNumber = wrongPhoneNumber,
                message);
        }

        [Test(Description = "Позитивный сет геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            //Arrange
            var expected = "hi@ya.ru";
            var contact = new Contact();

            //Act
            contact.Email = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер FullName возвращает неверную фамилию");
        }

        [TestCase("", "Должно возникать исключение, если емаил пустой",
            TestName = "Присвоение пустой строки в емаил")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов\" +\r\n                \"Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов\" +\r\n                \"Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если емаил слишком длинный",
            TestName = "Присвоение слишком длинной  строки в емаил")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(() => contact.Email = wrongEmail,
                message);
        }

        [Test(Description = "Позитивный сет геттера DateOfBirth")]
        public void TestDateOfBirthGet_CorrectValue()
        {
            //Arrange
            var expected = DateTime.Now.AddYears(-10);
            var contact = new Contact();

            //Act
            contact.DateOfBirth  = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер DateOfBirth возвращает неверную фамилию");
        }

        [Test(Description = "Присвоение слишком раннего времени в  DateOfBirth")]
        public void TestDateOfBirthSet_LessThan1900()
        {
            //Arrange
            var wrongDateOfBirth = DateTime.Now.AddYears(-1000);
            var contact = new Contact();
            var message = "Должно возникать исключение, если дата меньше 1900 года";

            //Assert & Act
            Assert.Throws<ArgumentException>(() => contact.DateOfBirth = wrongDateOfBirth,
                message);
        }

        [Test(Description = "Присвоение слишком позднего времени в  DateOfBirth")]
        public void TestDateOfBirthSet_MoreThanNow()
        {
            //Arrange
            var wrongDateOfBirth = DateTime.Now.AddYears(1000);
            var contact = new Contact();
            var message = "Должно возникать исключение, если дата больше текущей";

            //Assert & Act
            Assert.Throws<ArgumentException>(() => contact.DateOfBirth = wrongDateOfBirth,
                message);
        }

        [Test(Description = "Позитивный сет геттера VKID")]
        public void TestVkIDGet_CorrectValue()
        {
            //Arrange
            var expected = "12312";
            var contact = new Contact();

            //Act
            contact.Email = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер VkID возвращает неверную фамилию");
        }

        [TestCase("", "Должно возникать исключение, если VkID пустой",
            TestName = "Присвоение пустой строки в VkID")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов\" +\r\n                \"Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов\" +\r\n                \"Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если VkID слишком длинный",
            TestName = "Присвоение слишком длинной  строки в VkID")]
        public void TestVkIDSet_ArgumentException(string wrongVkID, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert & Act
            Assert.Throws<ArgumentException>(() => contact.VkID = wrongVkID,
                message);
        }

        [Test(Description = "Тест корректности конструктора Контакта")]
        public void TestContactConstructor_CorrectValue()
        {
            //Arrange
            var contact = new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345");

            //Assert & Act
            Assert.AreEqual(contact.FullName, "Михаил", "Конструктор Контакта неправильно присваивает имя");
            Assert.AreEqual(contact.PhoneNumber, "+7 (923) 444-1227", "Конструктор Контакта неправильно присваивает номер");
            Assert.AreEqual(contact.Email, "hi@ya.ru", "Конструктор Контакта неправильно присваивает ");
            Assert.AreEqual(contact.DateOfBirth, DateTime.Now.AddYears(-10), "Конструктор Контакта неправильно присваивает DateOfBirth");
            Assert.AreEqual(contact.VkID, "12345", "Конструктор Контакта неправильно присваивает VkID");
        }

        [Test(Description = "Тест корректности копирования Контакта")]
        public void TestContactClone_CorrectValue()
        {
            //Arrange
            var contact = new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345");
            var contactCloned = (Contact)contact.Clone();

            //Act
            var isCorrect = contact.CompareTo(contactCloned);

            //Assert
            Assert.AreEqual(isCorrect, 0, "Контакт неправильно копируется");
            
        }

        [Test(Description = "Тест корректности сравнения Контакта")]
        public void TestContactCompare_CorrectValue()
        {
            //Arrange
            var contact = new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345");

            //Assert & Act
            Assert.AreEqual(contact.CompareTo((Contact)contact.Clone()), 0, "Контакт неправильно копируется");
        }
    }
}
