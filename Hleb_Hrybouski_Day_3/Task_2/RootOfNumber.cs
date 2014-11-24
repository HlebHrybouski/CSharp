using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class RootOfNumber
    {
        public static double Root(int power, double number, double e)
        {
            if (number < 0 || e < 0)
            {
                return 0;
            }
            double x = 0;
            double x1 = 0.0001;
            do
            {
                x = x1;
                x1 = (1 / (double)power) * (((double)power - 1) * x + number / (Math.Pow(x, (double)power - 1)));
            }
            while (Math.Abs(x1 - x) > e);
            if (e > 0)
                return (double)(((int)(x1 / e)) * e);
            else
                return x1;
        }
    }
}
