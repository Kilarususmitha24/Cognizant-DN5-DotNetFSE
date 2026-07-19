using NUnit.Framework;
using System;
using MathLibrary;

namespace MathLibrary.Tests
{
    [TestFixture]
    public class MathLibraryTests
    {
        private MathLibrary math;

        [SetUp]
        public void Setup()
        {
            math = new MathLibrary();
        }

        [TestCase(10, 5, 5)]
        [TestCase(20, 10, 10)]
        [TestCase(50, 30, 20)]
        public void TestSubtraction(int a, int b, int expected)
        {
            Assert.AreEqual(expected, math.Subtraction(a, b));
        }

        [TestCase(5, 5, 25)]
        [TestCase(10, 2, 20)]
        [TestCase(7, 8, 56)]
        public void TestMultiplication(int a, int b, int expected)
        {
            Assert.AreEqual(expected, math.Multiplication(a, b));
        }

        [TestCase(20, 5, 4)]
        [TestCase(50, 10, 5)]
        [TestCase(100, 20, 5)]
        public void TestDivision(int a, int b, int expected)
        {
            Assert.AreEqual(expected, math.Division(a, b));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                math.Division(10, 0);
            });
        }

        [Test]
        public void TestAddAndClear()
        {
            math.Addition(20, 30);

            Assert.AreEqual(50, math.GetResult);

            math.AllClear();

            Assert.AreEqual(0, math.GetResult);
        }

        [TearDown]
        public void Cleanup()
        {
            math = null;
        }
    }
}
