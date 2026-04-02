using ConsoleApp10;

namespace ProductServiceTests
{
    public class Tests
    {
        private ProductService _service;
        private List<Product> _products;

        [SetUp]
        public void Setup()
        {
            _service = new ProductService();
            _products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200 },
            new Product { Name = "Mouse",  Price = 25   },
            new Product { Name = "Monitor",Price = 800  }
        };

        }

        [Test]
        public void GetExpensiveProducts_ReturnsOnlyHighPricedItems()
        {
            var result = _service.GetExpensiveProducts(_products);

            Assert.That(result, Has.Count.EqualTo(2));
            Assert.That(result, Contains.Item("Laptop"));
            Assert.That(result, Contains.Item("Monitor"));
            Assert.That(result, Does.Not.Contain("Mouse"));
        }

        [Test]
        public void GetExpensiveProducts_EmptyList_ReturnsEmptyList()
        {
            var result = _service.GetExpensiveProducts(new List<Product>());

            Assert.That(result, Is.Empty);
        }

    }
}
