using System;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression e1 = new ArithmeticProgression(7, 4);
            GeometricProgression e2 = new GeometricProgression(11, 3);
            Console.Write("Enter the number of element: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Arithmetic progression element: {e1.GetElement(n)}\nGeometric progression element: {e2.GetElement(n)}");
        }
    }
}
