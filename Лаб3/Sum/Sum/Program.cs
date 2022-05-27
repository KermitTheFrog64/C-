using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                sum += i;
            }
            Console.WriteLine("sum = {0}", sum);
        }
    }
}
