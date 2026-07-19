using NUnit.Framework;
using System;
using UserManagerLib;

namespace UserManagerLib.Tests
{
    [TestFixture]
    public class UserManagerTests
    {
        private UserManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new UserManager();
        }

        [Test]
        public void AddUser_ValidUser_ReturnsSuccessMessage()
        {
            User user = new User
            {
                Id = 101,
                Name = "Sai",
                Age = 22
            };

            string result = manager.AddUser(user);

            Assert.That(result, Is.EqualTo("User Added Successfully"));
        }

        [Test]
        public void AddUser_NullUser_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
                manager.AddUser(null));
        }

        [Test]
        public void AddUser_EmptyName_ThrowsArgumentException()
        {
            User user = new User
            {
                Id = 102,
                Name = "",
                Age = 22
            };

            Assert.Throws<ArgumentException>(() =>
                manager.AddUser(user));
        }

        [Test]
        public void AddUser_InvalidAge_ThrowsArgumentException()
        {
            User user = new User
            {
                Id = 103,
                Name = "Rahul",
                Age = 15
            };

            Assert.Throws<ArgumentException>(() =>
                manager.AddUser(user));
        }

        [TearDown]
        public void Cleanup()
        {
            manager = null;
        }
    }
}
