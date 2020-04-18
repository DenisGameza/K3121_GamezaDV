using System;

namespace progressions
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arith = new ArithmeticProgression(1, 2);
            Console.WriteLine("Введите номер члена арифметической прогрессии: ");
            int k = 0;
            k=Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} член арифметической прогрессии = {1}", k.ToString(), arith.GetElement(k).ToString());
            GeometricProgression geo = new GeometricProgression(1, 2);
            Console.WriteLine("Введите номер члена геометрической прогрессии: ");
            int n = 0;
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} член геометрической прогрессии = {1}", n.ToString(), geo.GetElement(n).ToString());
        }
    }
}
