using System;
using System.Collections.Generic;
using System.Text;

namespace Progressions
{
    class GeometricProgression : IProgression
    {
        public double GetElement(int k)
        {  return (b1 * Math.Pow(q, k - 1)); }
        private int b1;
        private float q;
        public GeometricProgression(int b1, float q) {
            this.b1 = b1; this.q = q;   }
    }
}
