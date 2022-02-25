using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double numbersBetweemZeroAndNine = 0;
            double numbersBetweenTenAndNineteen = 0;
            double numbersBetweentwentyAndTirty = 0;
            double countNumbersZeroToNine = 0;
            double countNumbers10to19 = 0;
            double countNumbers20to29 = 0;
            double countNumbers30to39 = 0;
            double countNumbers40to50 = 0;
            double countInvalidNumbers = 0; 
            double sum = 0;
            for(int i = 1; i <= num; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (numbers >= 0 && numbers <= 9)
                {
                    countNumbersZeroToNine++;
                    numbersBetweemZeroAndNine = numbers * 0.2;
                    sum += numbersBetweemZeroAndNine;
                }
                if (numbers >= 10 && numbers <= 19)
                {
                    countNumbers10to19++;
                    numbersBetweenTenAndNineteen = numbers * 0.3;
                    sum += numbersBetweenTenAndNineteen;
                }
                if (numbers >= 20 && numbers <= 29)
                {
                    countNumbers20to29++;
                    numbersBetweentwentyAndTirty = numbers * 0.4;
                    sum += numbersBetweentwentyAndTirty;
                }
                if (numbers >= 30 && numbers <= 39)
                {
                    countNumbers30to39++;
                    sum += 50;
                }
                if (numbers >= 40 && numbers <= 50)
                {
                    countNumbers40to50++;
                    sum += 100;
                }
                if (50 < numbers)
                {
                    countInvalidNumbers++;
                    sum /=  2;
                }
                if (0 > numbers)
                {
                    countInvalidNumbers++;
                    sum /= 2;
                }
            }            
            Console.WriteLine($"{sum:f2}");
            double percent = countNumbersZeroToNine / num * 100;
            Console.WriteLine($"From 0 to 9: {percent:f2}%");
            double percentFrom10to19 = countNumbers10to19/ num * 100;
            Console.WriteLine($"From 10 to 19: {percentFrom10to19:f2}%");
            double percentFrom20to29 = countNumbers20to29 / num * 100;
            Console.WriteLine($"From 20 to 29: {percentFrom20to29:f2}%");
            double percentFrom30to39 = countNumbers30to39 / num * 100;
            Console.WriteLine($"From 30 to 39: {percentFrom30to39:f2}%");
            double percentFrom40to49 = countNumbers40to50 / num * 100;
            Console.WriteLine($"From 40 to 50: {percentFrom40to49:f2}%");
            double percentInvalidNumbers = countInvalidNumbers / num * 100;
            Console.WriteLine($"Invalid numbers: {percentInvalidNumbers:f2}%");
        }
    }
}
