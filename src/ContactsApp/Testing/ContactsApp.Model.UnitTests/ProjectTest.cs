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
            //Arrange
            var expected = new List<Contact> { new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345")};
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual, "Геттер Contacts возвращает неверные контакты");
        }

        [Test(Description = "Позитивный тест сеттера Contacts")]
        public void TestContactsSet_CorrectValue()
        {
            //Arrange
            var expected = new List<Contact> { new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345")};
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(expected, actual, "Сеттер Contacts присваивает неверные контакты");
        }

        [Test(Description = "Поиск именинника. Результативный поиск в наполненном списке")]
        public void TestGetBirthday_CorrectValue()
        {
            //Arrange
            var expected = new List<Contact> { 
                new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345"),
            new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10).AddDays(-10), "12345")};
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual = new List<Contact> { expected[0] };

            //Assert
            Assert.AreEqual(project.GetContactsByDateOfBirth(DateTime.Now), actual,
                "Поиск именинника работает неверно");
        }

        [Test(Description = "Поиск именинника. Неудачный поиск в наполненном списке")]
        public void TestGetBirthday_SearchFail()
        {
            //Arrange
            var expected = new List<Contact> {
                new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10), "12345"),
            new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",
                DateTime.Now.AddYears(-10).AddDays(-10), "12345")};
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual = new List<Contact> {};

            //Assert
            Assert.AreEqual(project.GetContactsByDateOfBirth(DateTime.Now.AddDays(2)), actual,
                "Поиск именинника работает неверно");
        }

        [Test(Description = "Поиск именинника. Поиск в пустом списке")]
        public void TestGetBirthday_EmptyList()
        {
            //Arrange
            var expected = new List<Contact> { };
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual = new List<Contact> { };

            //Assert
            Assert.AreEqual(project.GetContactsByDateOfBirth(DateTime.Now), actual,
                "Поиск именинника работает неверно");
        }

        [Test(Description = "Поиск по подстроке. Поиск в наполненном массиве")]
        public void TestFindContacts_FilledUp()
        {
            //Arrange
            var expected = new List<Contact> { 
                new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",DateTime.Now.AddYears(-10), "12345"),
                new Contact("Олег", "+7 (923) 444-1227", "hi@ya.ru",DateTime.Now.AddYears(-10), "12345"),
            };
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual =  new List<Contact> { expected[0] };

            //Assert
            Assert.AreEqual(project.FindContacts("Мих"), actual, "Поиск по подстроке работает неверно. Должен вернуть непустой список.");
        }

        [Test(Description = "Поиск по подстроке. Неудачный поиск в наполненном массиве")]
        public void TestFindContacts_NothingReturned()
        {
            //Arrange
            var expected = new List<Contact> {
                new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",DateTime.Now.AddYears(-10), "12345"),
                new Contact("Олег", "+7 (923) 444-1227", "hi@ya.ru",DateTime.Now.AddYears(-10), "12345"),
            };
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual = new List<Contact> { };

            //Assert
            Assert.AreEqual(project.FindContacts("Макс"), actual, "Поиск по подстроке работает неверно. Должен вернуть пустой список.");
        }

        [Test(Description = "Поиск по подстроке. Пустой поисковый запрос")]
        public void TestFindContacts_EmptyQuery()
        {
            //Arrange
            var expected = new List<Contact> {
                new Contact("Михаил", "+7 (923) 444-1227", "hi@ya.ru",DateTime.Now.AddYears(-10), "12345"),
                new Contact("Олег", "+7 (923) 444-1227", "hi@ya.ru",DateTime.Now.AddYears(-10), "12345"),
            };
            var project = new Project();

            //Act
            project.Contacts = expected;
            var actual = expected;

            //Assert
            Assert.AreEqual(project.FindContacts(""), actual, "Поиск по подстроке работает неверно. Должен вернуть все контакты.");
        }

        [Test(Description = "Поиск по подстроке. Пустой список контактов")]
        public void TestFindContacts_EmptyProject()
        {
            //Arrange
            var project = new Project();

            //Act
            var actual = new List<Contact> { };

            //Assert
            Assert.AreEqual(project.FindContacts("32fsd"), actual, "Поиск по подстроке работает неверно. Должен вернуть ничего.");
        }
    }
}
