using NUnit.Framework;
using UtilLib;

namespace UtilLib.Tests
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_ValidUrl_ReturnsHostName()
        {
            string actual = parser.ParseHostName("https://www.google.com");

            Assert.That(actual, Is.EqualTo("www.google.com"));
        }

        [Test]
        public void ParseHostName_EmptyUrl_ReturnsEmptyString()
        {
            string actual = parser.ParseHostName("");

            Assert.That(actual, Is.EqualTo(string.Empty));
        }

        [TearDown]
        public void Cleanup()
        {
            parser = null;
        }
    }
}
