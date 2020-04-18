using System;

namespace Loop
{
    class Loop
    {
        static void Main(string[] args)
        {
            int[] MyArray;
            int t = int.Parse(Console.ReadLine());
            MyArray = new int[t];
            for (int j = 0; j < MyArray.Length; ++j) {
                Console.Write("a[{0}]=", j);
                MyArray[j] = int.Parse(Console.ReadLine());
            }
            foreach (int z in MyArray) Console.Write("{0} ", z);


            Console.Write("\n n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n) {
                Console.Write(" " + i);
                i += 2;
            }
            Console.Write("\ndo while: \t\t");
            i = 1;
            do {
                Console.Write(" " + i);
                i += 2;
            } while (i <= n);
            Console.Write("\nFor: \t\t"); 
            for (i = 1; i <= n; i += 2) { 
                Console.Write(" " + i);
            }


            double x, x1, x2, y;
            Console.WriteLine("\n Enter x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0,10}|{1,10}", "x","sin(x)");
            x = x1;
            do {
                y = Math.Sin(x);
                Console.WriteLine("{0,10}|{1,10}", x, y);
                x = x + 0.01;
            } while (x <= x2);

            Console.WriteLine("\n Enter x1': ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter x2': ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0,10}|{1,10}", "x", "sin(x)");
            x = x1;
            while (x <= x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("{0,10}|{1,10}", x, y);
                x = x + 0.01;
            }

            int a, b, temp;
            Console.WriteLine("\n Enter a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter b: ");
            b = Int32.Parse(Console.ReadLine());
            temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("\n a={0} b={1}", a, b);

            Console.WriteLine("Enter a': ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter b': ");
            b = Int32.Parse(Console.ReadLine());
            temp = a;
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            } while (temp != b);
            Console.WriteLine("\n a'={0} b'={1}", a, b);
        }
    }
}
