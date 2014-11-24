using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class CompareByTheSmallestSumOfLines : ICustomComparer
    {
        public int Comparer(int[] arr1, int[] arr2)
        {
            if (arr1.Sum() > arr2.Sum())
            {
                return -1;
            }
            else
            {
                if (arr1.Sum() < arr2.Sum())
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
