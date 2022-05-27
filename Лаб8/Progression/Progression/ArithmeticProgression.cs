using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Progression
{
    class ArithmeticProgression : IProgression
    {
        public int A1 { get; private set; }
        public int D { get; private set; }

        public ArithmeticProgression(int a1, int d)
        {
            A1 = a1;
            D = d;
        }

        public double GetElement(double k)
        {
            double e = A1 + D * (k - 1);
            return e;
        }
    }
}
