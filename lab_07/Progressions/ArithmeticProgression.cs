using System;
using System.Collections.Generic;
using System.Text;

namespace progressions
{
    class ArithmeticProgression : Progression
    {
        private int a1, d;
        public override double GetElement(int k)
        { return (a1 + (k - 1) * d); }
        public ArithmeticProgression(int a1, int d)
        { this.a1 = a1; this.d = d; }
    }
}
