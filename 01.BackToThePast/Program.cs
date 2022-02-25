using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double even = 0;
            double odd = 0;
            double sum = 0;
            double oddSum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            for (int i = 1; i <= N; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                    sum += num;
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
                else
                {
                    odd += num;
                    oddSum += num;
                    if (num > maxOdd)
                    {
                        maxOdd = num;
                    }
                    if (num < minOdd)
                    {
                        minOdd = num;
                    }
                }
            } 
            Console.WriteLine($"OddSum={odd:f2},");
            if (odd != 0)
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }else
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            Console.WriteLine($"EvenSum={even:f2},");
            if (even != 0)
            {
                Console.WriteLine($"EvenMin={min:f2},");
                Console.WriteLine($"EvenMax={max:f2}");
            } else
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
