using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class CompareByTheHighestElementOfLine : ICustomComparer
    {
         public int Comparer(int[] arr1, int[] arr2)
        {
            int max1, max2;
            max1 = arr1.Max();
            max2 = arr2.Max();

            if (max1 > max2)
                return 1;
            else
                if (max1 < max2)
                    return -1;                
            return 0;
         }

         
    }
}
