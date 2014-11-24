using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class ShoppingCart
    {
        private ValueCalculator valueCalc;

        public IEnumerable<Product> Products { get; set; }

        public ShoppingCart(ICalculator calculator)
        {
            valueCalc = new ValueCalculator(calculator);
        }

        public decimal CalculateProductTotal()
        {
            return valueCalc.ValueProducts(Products);
        }
    }
}
