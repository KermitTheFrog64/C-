using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array;
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            Array = new int[n];
            Init(Array);

            int sum = Sum(Array);
            Console.WriteLine($"Sum = {sum}");

            int mid = Middle(Array, sum);
            Console.WriteLine($"Middle = {mid}");

            int sum1 = Sum1(Array);
            Console.WriteLine($"Sum1 = {sum1}");

            int sum2 = Sum2(Array);
            Console.WriteLine($"Sum2 = {sum2}");

            int minIndex, maxIndex;
            Extreme(Array, out minIndex, out maxIndex);
            Console.WriteLine("Maximum or minimum?");
            string def = Console.ReadLine();
            switch (def)
            {
                case "Maximum":
                    Console.WriteLine($"{maxIndex}");
                    break;
                case "Minimum":
                    Console.WriteLine($"{minIndex}");
                    break;
            }

            int multy = Multiply(Array, minIndex, maxIndex);
            Console.WriteLine($"Multiply = {multy}");
        }

        private static int Multiply(int[] Array, int minIndex, int maxIndex)
        {
            int multy = 1;
            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                multy *= Array[i];
            }

            return multy;
        }

        private static void Extreme(int[] Array, out int minIndex, out int maxIndex)
        {
            int max = Array[0];
            int min = Array[0];
            minIndex = 0;
            maxIndex = 0;
            for (int i = 0; i < Array.Length; i++)
                if (Array[i] > max)
                {
                    max = Array[i];
                    maxIndex = i;
                }
            for (int i = 0; i < Array.Length; i++)
                if (Array[i] < min)
                {
                    min = Array[i];
                    minIndex = i;
                }
        }

        private static int Sum2(int[] Array)
        {
            int sum2 = 0;
            Console.WriteLine("Even or uneven?");
            string type = Console.ReadLine();
            switch (type)
            {
                case "Even":
                    for (int i = 0; i < Array.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            sum2 += Array[i];
                        }
                    }
                    break;
                case "Uneven":
                    for (int i = 0; i < Array.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum2 += Array[i];
                        }
                    }
                    break;
            }

            return sum2;
        }

        private static int Sum1(int[] Array)
        {
            int sum1 = 0;
            Console.WriteLine("Positive or negative?");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Positive":
                    for (int i = 0; i < Array.Length; i++)
                    {
                        if (Array[i] > 0)
                        {
                            sum1 += Array[i];
                        }
                    }
                    break;
                case "Negative":
                    for (int i = 0; i < Array.Length; i++)
                    {
                        if (Array[i] < 0)
                        {
                            sum1 += Array[i];
                        }
                    }
                    break;
            }

            return sum1;
        }

        private static int Middle(int[] Array, int sum)
        {
            return sum / Array.Length;
        }

        private static int Sum(int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }

            return sum;
        }

        private static void Init(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                Array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
