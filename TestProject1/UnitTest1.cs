
using review4Week;

namespace TestProject1
{
    public class Tests
    {
        private UserRegistration registration;
        private SortingFunction sortingFunction;
        [SetUp]
        public void Setup()
        {
            registration = new UserRegistration();
            sortingFunction = new SortingFunction();
        }

        [Test]
        public void ValidateName_Test1()
        {
            string name = "Asmita";
            bool expected = true;
            bool actul = registration.ValidateName(name);
            Assert.AreEqual(expected, actul);
        }
        [Test]
        public void ValidateNotName_Test1()
        {
            string name = "2345";
            bool expected = false;
            bool actul = registration.ValidateName(name);
            Assert.AreEqual(expected, actul);
        }

        [Test]
        public void ValidateAge_Test1()
        {
            int age = 23;
            bool expected = true;
            bool actul = registration.ValidateAge(age);
            Assert.AreEqual(expected, actul);
        }

        [Test]
        public void ValidateNotAge_Test1()
        {
            int age = 6;
            bool expected = false;
            bool actul = registration.ValidateAge(age);
            Assert.AreEqual(expected, actul);
        }

        [Test]
        public void ValidateEmail_Test1()
        {
            string email = "asmita235@gmail.com";
            bool expected = true;
            bool actul = registration.ValidateEmail(email);
            Assert.AreEqual(expected, actul);
        }

        [Test]
        public void ValidateNotEmail_Test1()
        {
            string email = "asmita235@.com";
            bool expected = false;
            bool actul = registration.ValidateEmail(email);
            Assert.AreEqual(expected, actul);
        }

        [Test]
        public void ValidateList_Test1()
        {
            List<int> list = new List<int> { 1, 4, 5, 6, 8, 3, 2, 7 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> actual = sortingFunction.SortList(list);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateNotSortedList_Test1()
        {
            List<int> list = new List<int> { };
            List<int> expected = new List<int> { };
            List<int> actual = sortingFunction.SortList(list);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateEmptySortedList_Test1()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> actual = sortingFunction.SortList(list);
            Assert.AreEqual(expected, actual);
        }


    }
}