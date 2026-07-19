using NUnit.Framework;
using System;
using AccountsManagerLib;

namespace AccountsManagerLib.Tests
{
    [TestFixture]
    public class AccountManagerTests
    {
        private AccountManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new AccountManager();
        }

        [Test]
        public void Login_ValidUser1_ReturnsWelcomeMessage()
        {
            string actual = manager.Login("user_1", "secret@user11");

            Assert.That(actual,
                Is.EqualTo("Welcome user_1!!!"));
        }

        [Test]
        public void Login_ValidUser2_ReturnsWelcomeMessage()
        {
            string actual = manager.Login("user_2", "secret@user22");

            Assert.That(actual,
                Is.EqualTo("Welcome user_2!!!"));
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsInvalidMessage()
        {
            string actual = manager.Login("abc", "123");

            Assert.That(actual,
                Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void Login_EmptyUserId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                manager.Login("", "secret@user11"));
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                manager.Login("user_1", ""));
        }

        [TearDown]
        public void Cleanup()
        {
            manager = null;
        }
    }
}
