using NUnit.Framework;

namespace FourSeasonsLib.Tests
{
    [TestFixture]
    public class FourSeasonsTests
    {
        private FourSeasons season;

        [SetUp]
        public void Setup()
        {
            season = new FourSeasons();
        }

        private static object[] SeasonData =
        {
            new object[] {1, "Winter"},
            new object[] {4, "Spring"},
            new object[] {7, "Summer"},
            new object[] {10, "Autumn"},
            new object[] {15, "Invalid Month"}
        };

        [Test]
        [TestCaseSource(nameof(SeasonData))]
        public void GetSeason_Test(int month, string expected)
        {
            string actual = season.GetSeason(month);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void Cleanup()
        {
            season = null;
        }
    }
}
