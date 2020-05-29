using System;
using System.Collections.Generic;
using System.Text;

namespace Progressions
{
    class ArithmeticProgression : IProgression
    {
        public double GetElement(int k) {
            return (a1 + (k - 1) * d); }
        private int a1, d;
        public ArithmeticProgression(int a1, int d) {
            this.a1 = a1; this.d = d; }
    }
}
