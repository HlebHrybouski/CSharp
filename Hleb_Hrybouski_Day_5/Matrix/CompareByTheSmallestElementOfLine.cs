using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class CompareByTheSmallestElementOfLine : ICustomComparer
    {
        public int Comparer(int[] arr1, int[] arr2)
        {
            int min1, min2;
            min1 = arr1.Min();
            min2 = arr2.Min();

            if (min1 > min2)
                return -1;
            else
                if (min1 < min2)
                    return 1;
            return 0;
        }

    }
}
