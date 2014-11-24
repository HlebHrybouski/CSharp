using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public interface ICustomComparer
    {
        int Comparer(int[] array1, int[] array2);
    }
}
