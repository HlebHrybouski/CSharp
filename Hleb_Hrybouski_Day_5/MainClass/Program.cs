using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix;

namespace MainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[4] { 3, 4, 5, 1 };
            jaggedArray[1] = new int[3] { 1, 9, 10 };
            jaggedArray[2] = new int[2] { 6, 9 };
            jaggedArray[3] = new int[6] { 1, 6, 2, 3, 1, 1 };
            ICustomComparer icomparer = new CompareByTheSmallestSumOfLines();
            Matrix.SortMatrix.Sort(icomparer, jaggedArray);
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.Write("\n");
            }
            Console.Read();

        }
    }
}
