using System;

namespace _09._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{час} : {минути}"

            for(int hours = 0; hours <=23; hours ++)
            {
                for(int minutes = 0; minutes <=59; minutes++)
                {
                    Console.WriteLine($"{hours} : {minutes}");
                }
            }
        }
    }
}
