using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class Discount : ICalculator
    {
        private static int precent;

        public Discount(int prec)
        {
            precent = prec;
        }

        public decimal Calculate(decimal sumOfProducts)
        {
            return (sumOfProducts - (sumOfProducts * precent)/100);
        }
    }
}
