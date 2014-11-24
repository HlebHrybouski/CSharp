using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 1, 2, 3, 4, 5 };
            double[] b = { 1, 2, 3, 4, 5 };
            Polynom poly1 = new Polynom(a);
            poly1.print();
            Polynom poly2 = new Polynom(b);
            poly2.print();
            Polynom poly3 = new Polynom();
            poly3.power = 10;
            poly3 = poly2 * poly1;
            poly3.print();
            

            Polynom poly4 = new Polynom(1, 2, 3, 4, 5, 6, 7);
            poly4.print();
            Console.Read();
        }
    }
}
