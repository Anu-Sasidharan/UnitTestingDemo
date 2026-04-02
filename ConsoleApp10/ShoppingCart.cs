using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class ShoppingCart
    {
        private List<Product> _items = new();

        public void AddItem(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            _items.Add(product);
        }

        public void Clear() => _items.Clear();

        public int ItemCount => _items.Count;
    }

}
