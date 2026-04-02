using System.Drawing;
using ConsoleApp10;

namespace ShapeFactoryTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void CreateShape_Circle_ReturnsCircleInstance()
        {
            var factory = new ShapeFactory();
            var result = factory.CreateShape("circle");

            Assert.That(result, Is.InstanceOf<Circle>());
        }

        [Test]
        public void CreateShape_Rectangle_ReturnsRectangleInstance()
        {
            var factory = new ShapeFactory();
            var result = factory.CreateShape("rectangle");

            Assert.That(result, Is.InstanceOf<ConsoleApp10.Rectangle>());
        }

        [Test]
        public void CreateShape_AnyShape_IsAlwaysAShape()
        {
            var factory = new ShapeFactory();
            var result = factory.CreateShape("circle");

            // Works for base class or interface too
            Assert.That(result, Is.AssignableTo<Shape>());
        }
    }
}

