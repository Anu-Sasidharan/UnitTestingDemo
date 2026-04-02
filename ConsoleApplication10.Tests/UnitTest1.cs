using ConsoleApp10;

namespace ConsoleApplication10.Tests
{
    [TestFixture]
    public class Tests
    {
        private Utility _utility;
        [SetUp]
        public void Setup()
        {
            _utility = new Utility();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            //Arrange
            int no1 = 13;
            int no2 = 15;
            int expected = 28;

            //Act
            int actual = _utility.Sum(no1, no2);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
