using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            // while:
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }
            // do while:
            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);
            // for:
            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }
            //SIN
            double x, x1, x2, y;
            Console.WriteLine("\nenter the first border");
            x1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the second border");
            x2 = Double.Parse(Console.ReadLine());
            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("Sin(x) = {0}", y);
                x = x + 0.01;
            }
            while (x <= x2);
            //Evklid
            Console.WriteLine("\nenter the first integer");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nenter the second integer");
            int b = Int32.Parse(Console.ReadLine());
            int temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("nod = {0}", temp);
        }
    }
}
