using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class RandomMatrix
    {
        private const int M_SIZE = 4;
        private int[][] matrix = new int[M_SIZE][];
        private int[][] strt_mtrx;
        private Random rand = new Random();

        public int[][] Initialization()
        {
            for (int i = 0; i < M_SIZE; i++)
            {
                matrix[i] = new int[rand.Next(3, 10)];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rand.Next(1, 5);
                }
            }
            strt_mtrx = matrix;
            return matrix;
        }
    }
}
