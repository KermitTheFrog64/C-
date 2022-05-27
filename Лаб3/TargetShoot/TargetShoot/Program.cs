using System;

namespace TargetShoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int sum = 0;
            // Targen creating 
            Random rand = new Random();
            int centerX = rand.Next(-1, 1);
            int centerY = rand.Next(-1, 1);
            Console.Write("Number of shots: ");
            n = int.Parse(Console.ReadLine());
            // x and y array creating
            int[] x = new int[n], y = new int[n];
            for (int i = 0; i < n; i++)
            {
                int shift = rand.Next(-1, 1);
                Console.Write("x = ");
                x[i] = (int.Parse(Console.ReadLine())) - shift;
                Console.Write("y = ");
                y[i] = (int.Parse(Console.ReadLine())) - shift;
                if (Math.Pow(x[i] - centerX, 2) + Math.Pow(y[i] - centerY, 2) <= 1)
                {
                    Console.WriteLine("10 points!");
                    sum += 10;
                }
                else if (Math.Pow(x[i] - centerX, 2) + Math.Pow(y[i] - centerY, 2) <= 4)
                {
                    Console.WriteLine("5 point.");
                    sum += 5;
                }
                else if (Math.Pow(x[i] - centerX, 2) + Math.Pow(y[i] - centerY, 2) <= 9)
                {
                    Console.WriteLine("1 point.");
                    sum += 1;
                }
                else
                {
                    Console.WriteLine("Miss!");
                }
            }
            Console.WriteLine("Total score: {0}", sum);
            Console.WriteLine($"Центр мишени был выбран в точке с координатами x = {centerX}, y = {centerY}") ;
            
        }
    }
}
