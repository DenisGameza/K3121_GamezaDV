using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(5, 6, 10);
            if (t1.sides[0] == 0 || t1.sides[1] == 0 || t1.sides[2] == 0)
                Console.WriteLine("Треугольник не существует.");
            else
            {
                t1.PrintSides();
                Console.WriteLine("Периметр треугольника = {0}", t1.perim());
                Console.WriteLine("Площадь треугольника = {0}", t1.square());
            }
        }
    }
}
