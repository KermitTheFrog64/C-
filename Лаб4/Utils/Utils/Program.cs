using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);
            //SWAP
            Console.WriteLine("До swap: \t" + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t" + x + " " + y);
            //FACTORIAL
            int f; 
            bool ok;
            Console.WriteLine("Number for factorial:"); 
            x = int.Parse(Console.ReadLine());
            // Test the factorial function 
            ok = Utils.Factorial(x, out f);
            // Output factorial results 
            if (ok) 
                Console.WriteLine("Factorial(" + x + ") = " + f); 
            else
                Console.WriteLine("Cannot compute this factorial");
            // Square Triangle
            Console.WriteLine("Треугольник равносторонний?");
            string m = Console.ReadLine();
            int h;
            switch (m)
            {
                case "yes":
                case "да":
                    h = 1; 
                    break;
                default: 
                    h = 0; 
                    break;
            }
            double s;
            bool d = true;
            if (h == 1)
            {
                Console.WriteLine("Введите сторону:");
                double a1 = Double.Parse(Console.ReadLine());
                s = Operation.Square(a1);

            }
            else
            {
                Console.WriteLine("Введите первую сторону:");
                double a1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону:");
                double b1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите третью сторону:");
                double c1 = Double.Parse(Console.ReadLine());
                s = Operation.Square(a1, b1, c1, out d);
            }
            if (d == true)
                Console.WriteLine("Площадь треугольника = " + s);
            //Sqrt
            Console.WriteLine("Введите первый коэффициент:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэффициент:");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэффициент:");
            int c = Int32.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;
            int k = Operation.Korn(a, b, c, ref x1, ref x2);
            if (k == 1)
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = {3}, x2 = {4}", a, b, c, x1, x2);
            }
            else if (k == 0)
            {
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} равен x1 = x2 = {3}", a, b, c, x1);
            }
            else if (k == -1)
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет", a, b, c);
            }
        }
    }
}
