using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class Number
    {
        private static string newNumber = "";

        public static string GetNumberInOtherNumeralSystem(int p, int numb)
        {
            if (numb > 0 && p >= 2 && p <= 16)
            {
                newNumber = "";
                Convert(p, numb);
                return newNumber;
            }
            else
                return newNumber;
        }

        private static void Convert(int p, int numb)
        {
            if (numb >= p)
                Convert(p, numb / p);

            if (((numb % p) >= 10) && ((numb % p) < p))
                newNumber += Change(numb % p);
            else
            {
                newNumber += (numb % p).ToString();
            }

        }

        private static string Change(int temp)
        {
            switch (temp)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
            }
            return "";
        }

    }
}
