using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray;
            Console.WriteLine("Enter the size of array: ");
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n];
            int sum = 0;
            double avarage;
            int sumN = 0;
            int sumP = 0;
            int sumC = 0;
            int sumNC = 0;
            int max=0;
            int min=0;
            int maxi=0;
            int mini=0;
            for (int i = 0; i < MyArray.Length; ++i)
            {
                Console.Write("a[{0}]=", i);
                MyArray[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = MyArray[i];
                    min = MyArray[i];
                    maxi = i; mini = i;
                    sum += MyArray[i];
                    if (i % 2 == 0) sumC += MyArray[i];
                    else sumNC += MyArray[i];
                    if (MyArray[i] > 0) sumP += MyArray[i];
                    else sumN += MyArray[i];
                }
                else
                {
                    sum += MyArray[i];
                    if (i % 2 == 0) sumC += MyArray[i];
                    else sumNC += MyArray[i];
                    if (MyArray[i] > 0) sumP += MyArray[i];
                    else sumN += MyArray[i];
                    if (MyArray[i] > max)
                    {
                        max = MyArray[i];
                        maxi = i;
                    }
                    else if (MyArray[i] < min)
                    {
                        min = MyArray[i];
                        mini = i;
                    }
                }
            }
            Console.WriteLine("Sum: {0}", sum);
            avarage = sum / n;
            Console.WriteLine("Average: " + avarage);
            Console.WriteLine("Sum +: {0}", sumP);
            Console.WriteLine("Sum -: {0}", sumN);
            Console.WriteLine("Sum ch: {0}", sumC);
            Console.WriteLine("Sum ne: {0}", sumNC);
            Console.WriteLine("Max I: {0}", maxi);
            Console.WriteLine("Min I: {0}", mini);
            if (maxi < mini)
            {
                int temp = maxi;
                maxi = mini;
                mini = temp;
            }
            int multy = 1;
            for (int i = mini + 1; i < maxi; i++)
            {
                multy *= MyArray[i];
            }
            Console.WriteLine("Myltiply: "+ multy);
        }
    }
}
