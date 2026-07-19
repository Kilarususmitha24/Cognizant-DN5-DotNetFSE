using NUnit.Framework;

namespace LeapYearLib.Tests
{
    [TestFixture]
    public class LeapYearTests
    {
        private LeapYear leapYear;

        [SetUp]
        public void Setup()
        {
            leapYear = new LeapYear();
        }

        [TestCase(2000, true)]
        [TestCase(2024, true)]
        [TestCase(2023, false)]
        [TestCase(1900, false)]
        [TestCase(2400, true)]
        public void IsLeapYear_Test(int year, bool expected)
        {
            bool actual = leapYear.IsLeapYear(year);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void Cleanup()
        {
            leapYear = null;
        }
    }
}
