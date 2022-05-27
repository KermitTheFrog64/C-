using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle(9, 10, 17);
            tr1.Print();
            Triangle tr2 = new Triangle(17);
            tr2.Print();
            Triangle tr3 = new Triangle(13, 55, 39);
            tr3.Print();
        }
    }
}
