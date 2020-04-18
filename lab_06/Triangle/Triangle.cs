using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        public Double[] sides = new double[3];
        public Triangle(Double a, Double b, Double c)
        {

            if (a + b - c > 0 & a + c - b > 0 & b + c - a > 0)
            {
                this.sides[0] = a;
                this.sides[1] = b;
                this.sides[2] = c;
            }
            else this.sides[0] = this.sides[1] = this.sides[2] = 0;
        }
        public void PrintSides()
        {
            Console.WriteLine("Сторона A = {0}\nСторона B = {1}\nСторона C = {2}\n", this.sides[0], this.sides[1], this.sides[2]);
        }
        public Double perim(){ return (this.sides[0] + this.sides[1] + this.sides[2]); }
        public Double square(){
            Double p = perim();
            return Math.Sqrt((p / 2) * (p / 2 - this.sides[0]) * (p / 2 - this.sides[1]) * (p / 2 - this.sides[2]));
        }
    }
}
