using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopModel
{
    public class ValueCalculator 
    {
        private static ICalculator calculator;

        public ValueCalculator(ICalculator calc)
        {
            calculator = calc;
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return calculator.Calculate(sumOfProduct);
        }
    }
}
