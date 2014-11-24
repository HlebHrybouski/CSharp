using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Polynom
    {
        private double[] polyCoeff;
        private int polyPower;

        public Polynom()
        {

        }

        public Polynom(int power) //рандомная задача полинома
        {
            polyPower = power;
            polyCoeff = new double[polyPower];
            Random rand = new Random();
            for (int i = 0; i < polyPower; i++)
            {
                polyCoeff[i] = rand.Next(-10, 10);
            }
        }

        public Polynom(params double[] coeff)
        {
            polyPower = coeff.Length;
            polyCoeff = new double[polyPower];
            for (int i = 0; i < polyPower; i++)
            {
                polyCoeff[i] = coeff[i];
            }
        }

        public Polynom(double[] coeff, int power)
        {
            polyPower = power;
            polyCoeff = new double[polyPower];
            for (int i = 0; i < polyPower; i++)
            {
                polyCoeff[i] = coeff[i];
            }
        }

        public int power
        {
            get 
            { 
                return polyPower; 
            }
            set
            {
                polyPower = value;
                polyCoeff = new double[polyPower];
            }
        }

        private static Polynom init(Polynom a, Polynom b, int sign1, int sign2) //функция для сложения и вычитания полиномов
        {
            Polynom ab = new Polynom();
            ab.polyPower = a.polyCoeff.Length;
            ab.polyCoeff = new double[ab.polyPower];
            for (int i = 0; i < b.polyCoeff.Length; i++)
            {
                ab.polyCoeff[i] = sign2 * a.polyCoeff[i] + sign1 * b.polyCoeff[i];
            }
            for (int i = b.polyCoeff.Length; i < a.polyCoeff.Length; i++)
            {
                ab.polyCoeff[i] = sign2 * a.polyCoeff[i];
            }
            return ab;

        }


        public static Polynom operator +(Polynom a, Polynom b)
        {
            if (a.polyCoeff.Length > b.polyCoeff.Length)
            {
                return init(a, b, 1, 1);
            }
            else
            {
                return init(b, a, 1, 1);
            }
        }

        public static Polynom operator -(Polynom a, Polynom b)
        {
            Polynom ab = new Polynom();
            if (a.polyCoeff.Length > b.polyCoeff.Length)
            {
                ab = init(a, b, -1, 1);
            }
            else
            {
                ab = init(b, a, 1, -1);
            }
            return ab;
        }



        public static Polynom operator *(Polynom a, Polynom b)
        {
            Polynom ab = new Polynom();
            ab.polyPower = a.polyCoeff.Length + b.polyCoeff.Length - 1;
            ab.polyCoeff = new double[ab.polyPower];
            for (int i = 0; i < a.polyCoeff.Length; i++)
            {
                for (int j = 0; j < b.polyCoeff.Length; j++)
                {
                    ab.polyCoeff[i + j] += (a.polyCoeff[i] * b.polyCoeff[j]);
                }
            }
            return ab;
        }

        private static Polynom init(Polynom a, double b, int sign)
        {
            Polynom ab = a;
            ab.polyCoeff[0] += (sign * b);
            return ab;
        }

        public static Polynom operator +(Polynom a, double b)
        {
            return init(a, b, 1);
        }

        public static Polynom operator +(double b, Polynom a)
        {
            return init(a, b, 1);
        }

        public static Polynom operator -(Polynom a, double b)
        {
            return init(a, b, -1);
        }

        public static Polynom operator -(double b, Polynom a)
        {
            return init(a, b, -1);
        }

        public static Polynom operator *(Polynom a, double b)
        {
            Polynom ab = a;
            for (int i = 0; i < ab.polyCoeff.Length; i++)
            {
                ab.polyCoeff[i] *= b;
            }
            return ab;
        }

        public static Polynom operator *(double b, Polynom a)
        {
            Polynom ab = a;
            for (int i = 0; i < ab.polyCoeff.Length; i++)
            {
                ab.polyCoeff[i] *= b;
            }
            return ab;
        }

        public void print()
        {
            for (int i = 0; i < polyCoeff.Length; i++)
            {
                Console.Write(polyCoeff[i] + " ");
            }
            Console.Write("\n");
        }


    }
}
