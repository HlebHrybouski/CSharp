using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class SortMatrix
    {
        public static void Sort(ICustomComparer icomparer, int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                    if (icomparer.Comparer(array[i], array[j]) == -1)
                        Swap(array, i, j);                      
        }

        private static void Swap(int[][] array, int i, int j)
        {
            int[] temp;
            temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }

    }
        
}
