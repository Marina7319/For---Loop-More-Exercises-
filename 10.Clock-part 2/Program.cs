using System;

namespace _10.Clock_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int second = 0; second <= 59; second++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {second}");
                    }
                }
            }
        }
    }
}
