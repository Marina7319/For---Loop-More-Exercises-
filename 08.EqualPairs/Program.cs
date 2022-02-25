using System;

namespace _08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            double even = 0;
            double odd = 0;
            double sum = 0;
            bool areTheSumEqual = true;         
            for (int i = 1; i <= pairs; i++)
            {
                double numOne = double.Parse(Console.ReadLine());
                double numTwo = double.Parse(Console.ReadLine());
                double currentSum = numOne + numTwo;
                if ( i % 2 == 0)
                {
                    even = numOne + numTwo;
                }
                else
                {
                    odd = numTwo + numOne;                  
                }
                if(i > 1 && Math.Abs(even - odd) > sum)
                {
                    sum = Math.Abs(even - odd);
                    areTheSumEqual = false;
                }
            }
            if (areTheSumEqual == true)
            {
                Console.WriteLine($"Yes, value={odd}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={sum}");
            }
        }
    }
}
