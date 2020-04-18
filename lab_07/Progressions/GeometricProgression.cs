using System;
using System.Collections.Generic;
using System.Text;

namespace progressions
{
    class GeometricProgression : Progression
    { 
        private int b1;
        private float q;
        public override double GetElement(int k)
        { return (b1 * Math.Pow(q, k - 1)); }
        public GeometricProgression(int b1, float q)
        { this.b1 = b1; this.q = q; }
    }
}
