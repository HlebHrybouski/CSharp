using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Converter
    {
        //private static string number;
        private static string changedNumber = "";

        public static string To16(int number)
        {
            changedNumber = "";
            Convert(16, number);
            return changedNumber;
        }

        public static string To2(int number)
        {
            changedNumber = "";
            Convert(2, number);
            return changedNumber;
        }

        protected static void Convert(int countSystem, int numb)
        {
            if (numb >= countSystem)
                Convert(countSystem, numb / countSystem);

            if (((numb % countSystem) >= 10) && ((numb % countSystem) < countSystem))
                changedNumber += Change(numb % countSystem);
            else
            {
                changedNumber += (numb % countSystem).ToString();
            }
        }

        protected static string Change(int temp)
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
