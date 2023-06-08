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
    internal class ProjectTest
    {
        [Test(Description = "Позитивный тест геттера Contacts")]
        public void TestContactsGet_CorrectValue()
        {
            var expected = new List<Contact> { new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345")};
            var project = new Project();
            project.Contacts = expected;
            var actual = expected;
            Assert.AreEqual(expected, actual, "Геттер Contacts возвращает неверные контакты");
        }

        [Test(Description = "Позитивный тест сеттера Contacts")]
        public void TestContactsSet_CorrectValue()
        {
            var expected = new List<Contact> { new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345")};
            var project = new Project();
            project.Contacts = expected;
            var actual = expected;
            Assert.AreEqual(expected, actual, "Сеттер Contacts присваивает неверные контакты");
        }

        [Test(Description = "Позитивный тест поиска имениннков")]
        public void TestGetBirthday_CorrectValue()
        {
            var expected = new List<Contact> { new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345")};
            var project = new Project();
            project.Contacts = expected;
            var actual = expected;
            Assert.AreEqual(project.GetContactsByDateOfBirth(DateTime.Now), actual, "Поиск именинника работает неверно");
        }

        [Test(Description = "Позитивный тест поиска имениннков")]
        public void TestFindCotacts_CorrectValue()
        {
            var expected = new List<Contact> { new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345")};
            var project = new Project();
            project.Contacts = expected;
            var actual = expected;
            Assert.AreEqual(project.FindContacts("Мих"), actual, "Поиск по подстроке работает неверно");
        }
    }
}
