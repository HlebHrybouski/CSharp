using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class AlgorithmOfEuclid
    {
        public static int getNOD(int number_1, int number_2)
        {
            while (number_2 != 0)
            {
                int temp = number_1 % number_2;
                number_1 = number_2;
                number_2 = temp;
            }

            return number_1;
        }

        public static int getNOD(params int[] list)
        {
            int result = 0;
            for (int i = 0, j = i + 1; j < list.Length; i++, j++)
            {
                list[j] = getNOD(list[i], list[j]);
                result = list[j];
            }
            return result;
        }
    }

}
