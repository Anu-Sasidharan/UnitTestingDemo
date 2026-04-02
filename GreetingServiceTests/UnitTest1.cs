using System.ComponentModel;
using ConsoleApp10;

namespace GreetingServiceTests
{
    [TestFixture]
    public class Tests
    {
        private GreetingService _service;
        [SetUp]
        public void Setup()
        {
            _service = new GreetingService();
        }

        [Test]
        public void Greet_ValidName_ContainsName()
        {
            string result = _service.Greet("John");
            Assert.That(result, Does.Contain("John"));
        }

        [Test]
        public void Greet_ValidName_StartsWithHello()
        {
            string result = _service.Greet("John");
            Assert.That(result, Does.StartWith("Hello"));
        }

        [Test]
        public void Greet_EmptyName_ReturnsGuestMessage()
        {
            string result = _service.Greet("");
            Assert.That(result, Is.EqualTo("Hello, Guest!"));
        }

        [Test]
        public void Greet_ValidName_IgnoresCase()
        {
            string result = _service.Greet("john");
            Assert.That(result, Is.EqualTo("Hello, John! Welcome back.")
                .IgnoreCase);
        }
    }

}

