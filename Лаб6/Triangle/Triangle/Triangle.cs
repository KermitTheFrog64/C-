using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        public int A, B, C, P;
        public double S;


        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Triangle(int a)
        {
            this.A = a;
            this.B = a;
            this.C = a;
        }

        private bool Trian(int a, int b, int c)
        {
            if ((a + b < c) || (a + c < b) || (b + c < a))
                return false;
            else return true;
        }


        private void Perimetr()
        {
            this.P = A + B + C;
        }

        private void Square()
        {
            double p2 = P / 2;
            this.S = Math.Sqrt(p2 * (p2 - A) * (p2 - B) * (p2 - C));
        }

       
        public void Print()
        {
            bool ok = Trian(A, B, C);
            if (ok == true)
            {
                Perimetr();
                Square();
                Console.WriteLine("Первая сторона = {0}\nВторая сторона = {1}\nТретья сторона = {2}\nПериметр = {3}\nПлощадь = {4}\n\n ", A, B, C, P, S);
            }
            else
            {
                Console.WriteLine("Первая сторона = {0}\nВторая сторона = {1}\nТретья сторона = {2}\nТреугольник не существует\n\n", A, B, C);
            }
        }
    }    
}
