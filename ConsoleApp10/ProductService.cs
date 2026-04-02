using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class ProductService
    {
        public List<string> GetExpensiveProducts(List<Product> products)
        {
            return products
                .Where(p => p.Price > 500)
                .Select(p => p.Name)
                .ToList();
        }
    }

}
