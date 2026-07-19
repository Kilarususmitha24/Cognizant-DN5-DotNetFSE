using NUnit.Framework;
using System.Linq;
using CollectionsLib;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new EmployeeManager();
        }

        [Test]
        public void GetEmployees_ShouldNotContainNull()
        {
            var employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreNotNull(employees);
        }

        [Test]
        public void GetEmployees_ShouldContainEmployee100()
        {
            var employees = manager.GetEmployees();

            Assert.That(employees.Any(e => e.Id == 100), Is.True);
        }

        [Test]
        public void GetEmployees_ShouldContainUniqueEmployees()
        {
            var employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreUnique(employees);
        }

        [Test]
        public void CompareEmployeeCollections()
        {
            var list1 = manager.GetEmployees();
            var list2 = manager.GetEmployeesWhoJoinedInPreviousYears();

            CollectionAssert.AreEquivalent(list1, list2);
        }

        [TearDown]
        public void Cleanup()
        {
            manager = null;
        }
    }
}
