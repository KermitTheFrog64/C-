using System;
using System.Collections.Generic;
using System.Text;

namespace Progression
{
    class GeometricProgression : IProgression
    {
        public double B1 { get; private set; }
        public double Q { get; private set; }

        public GeometricProgression(double b1, double q)
        {
            B1 = b1;
            Q = q;
        }

        public double GetElement(double k)
        {
            double e = B1 * Math.Pow(Q, (k - 1));
            return e;
        }
    }
}
