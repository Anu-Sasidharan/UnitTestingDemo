using ConsoleApp10;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {

        private ShoppingCart _cart;

        [SetUp]
        public void Setup() => _cart = new ShoppingCart();

        [Test]
        public void AddItem_ValidProduct_IncreasesItemCount()
        {
            var product = new Product { Name = "Laptop", Price = 1000 };

            _cart.AddItem(product);

            // Test the SIDE EFFECT — count changed
            Assert.That(_cart.ItemCount, Is.EqualTo(1));
        }

        [Test]
        public void Clear_CartWithItems_EmptiesTheCart()
        {
            _cart.AddItem(new Product { Name = "Mouse", Price = 25 });
            _cart.AddItem(new Product { Name = "Keyboard", Price = 75 });

            _cart.Clear();

            Assert.That(_cart.ItemCount, Is.EqualTo(0));
        }

    }
}
