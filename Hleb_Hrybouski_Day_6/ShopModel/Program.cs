using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public static class Program
    {
        public static void Main()
        {
            ICalculator calculator = new Discount(3);
            var cart = new ShoppingCart(calculator)
            {
                Products = new List<Product>()
                {
                    new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                    new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                }
            };

            Console.WriteLine("Total price = {0}$", cart.CalculateProductTotal());
            Console.Read();
        }
    }
}