using Moq;
using NUnit.Framework;
using ConverterLib;

namespace ConverterLib.Tests
{
    [TestFixture]
    public class CurrencyCalculatorTests
    {
        private Mock<ICurrencyConverter> mockConverter;
        private CurrencyCalculator calculator;

        [SetUp]
        public void Setup()
        {
            mockConverter = new Mock<ICurrencyConverter>();

            mockConverter
                .Setup(x => x.ConvertToEuro(100))
                .Returns(92.50);

            calculator = new CurrencyCalculator(mockConverter.Object);
        }

        [Test]
        public void Convert_USDToEuro_ReturnsExpectedValue()
        {
            double result = calculator.Convert(100);

            Assert.That(result, Is.EqualTo(92.50));
        }

        [Test]
        public void Verify_Method_Called_Once()
        {
            calculator.Convert(100);

            mockConverter.Verify(
                x => x.ConvertToEuro(100),
                Times.Once);
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
            mockConverter = null;
        }
    }
}
