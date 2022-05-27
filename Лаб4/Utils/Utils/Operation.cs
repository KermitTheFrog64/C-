using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    class Operation
    {
        public static double Square(double a, double b, double c, out bool d)
        {
            bool ok = Triangle(a, b, c);
            if (ok)
            {
                double p = (a + b + c) / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                d = ok;
                return S;
            }
            else
            {
                d = ok;
                Console.WriteLine("Треугольник не существует");
            }
            return 0;
        }
        private static bool Triangle(double a, double b, double c)
        {
            bool ok = true;

            if ((a + b < c) || (a + c < b) || (b + c < a))
                ok = false;
            return ok;
        }
        public static double Square(double a)
        {
            double p = (3 * a) / 2;
            double S = Math.Sqrt(p * Math.Pow((p - a), 3));
            return S;
        }
        //Sqrt
        private static int ProvD(double d)
        {
            int k = 1;
            if (d == 0)
                k = 0;
            else if (d < 0)
                k = -1;
            return k;
        }
        public static int Korn(int a, int b, int c, ref double x1, ref double x2)
        {
            double d = b * b - 4 * a * c;
            int k = ProvD(d);
            if (k == 1)
            {
                x1 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                x2 = (-1 * b + Math.Sqrt(d)) / (2 * a);

            }
            else if (k == 0)
            {
                x1 = x2 = (-1 * b) / (2 * a);
            }
            return k;
        }
    }
}
