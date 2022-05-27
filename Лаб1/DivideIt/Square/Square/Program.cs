using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a perimeter value");
                string temp = Console.ReadLine();
                int P = Int32.Parse(temp);
                double p = P / 2;
                double a = P / 3;
                double S = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
                Console.WriteLine("Side={0:0.00} Square={1:0.00}", a, S);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}",
                e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An DivideByZero exception was thrown: {0}",
                e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
