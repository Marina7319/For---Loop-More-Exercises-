using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем капацитета на стадиона
            double capacityStadion = double.Parse(Console.ReadLine());
            //броя на всички фенове 
            double fens = double.Parse(Console.ReadLine());
            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;
            //секторите на които се намира
            for(int i=1; i <= fens; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                if( sector == 'A')
                {
                    a += 1;
                }
                if (sector == 'B')
                {
                    b += 1;
                }
                if (sector == 'V')
                {
                    v += 1;
                }
                if (sector == 'G')
                {
                    g += 1;
                }
            }
            //отпечатване на резултата 
            double averageA = a / fens * 100;
            Console.WriteLine($"{averageA:f2}%");
            double averageB = b / fens * 100;
            Console.WriteLine($"{averageB:f2}%");
            double averageV = v / fens * 100;
            Console.WriteLine($"{averageV:f2}%");
            double averageG = g / fens * 100;
            Console.WriteLine($"{averageG:f2}%");
            double sumFens = fens / capacityStadion * 100;
            Console.WriteLine($"{sumFens:f2}%");
        }
    }
}
