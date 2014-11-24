using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class BinaryAlgorithmOfEuclid
    {
        public static int getNOD(int number_1, int number_2)
        {
            if (number_1 == 0 || number_2 == 0)
                return number_1 == 0 ? number_2 : number_1;

            if (number_1 == number_2)
                return number_1;

            if (number_1 == 1 || number_2 == 1)
                return 1;

            if (number_1 % 2 == 0 && number_2 % 2 == 0)
                return 2 * getNOD(number_1 / 2, number_2 / 2);

            if (number_1 % 2 == 0 && number_2 % 2 == 1)
                return getNOD(number_1 / 2, number_2);

            if (number_1 % 2 == 1 && number_2 % 2 == 0)
                return getNOD(number_1, number_2 / 2);

            if (number_1 % 2 == 1 && number_2 % 2 == 1)
                return number_2 > number_1 ? getNOD((number_2 - number_1) / 2, number_1) : getNOD((number_1 - number_2) / 2, number_2);

            return 0;
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
