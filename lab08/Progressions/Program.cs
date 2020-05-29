using System;

namespace Progressions
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arith = new ArithmeticProgression(1, 2);
            int k = 5;
            Console.WriteLine("{0} член арифметической прогрессии = {1}", k.ToString(), arith.GetElement(k).ToString());
            GeometricProgression geom = new GeometricProgression(1, 2);
            k = 5;
            Console.WriteLine("{0} член геометрической прогрессии = {1}", k.ToString(), geom.GetElement(k).ToString());
        }
    }
}
