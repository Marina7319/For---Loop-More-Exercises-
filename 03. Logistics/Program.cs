using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double sumPrice = 0;
            double bus = 0;
            double train = 0;
            double TIR = 0;
            double busPrice = 0;
            double TIRPrice = 0;
            double trainPrice = 0;
            int countbagage = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countbagage; i++)
            {
                int tonas = int.Parse(Console.ReadLine());
                sum += tonas;
                if (tonas <= 3)
                {
                    busPrice += 200 * tonas;
                    sumPrice = busPrice;
                    bus += tonas;
                }
                if (tonas >= 4 && tonas <= 11)
                {
                    TIRPrice += 175 * tonas;
                    sumPrice = TIRPrice;
                    TIR += tonas;
                }
                if (tonas >= 12)
                {
                    trainPrice += 120 * tonas;
                    sumPrice = trainPrice;
                    train += tonas;
                }
            }
            double averagePriceForTon = (trainPrice + TIRPrice + busPrice)/sum;
            Console.WriteLine($"{averagePriceForTon:f2}");
            double total = sum / 100;
            double busAverage = bus / total;
            double TIRAverage = TIR / total;
            double trainAverage = train / total;
            Console.WriteLine($"{busAverage:f2}%");
            Console.WriteLine($"{TIRAverage:f2}%");
            Console.WriteLine($"{trainAverage:f2}%");
        }
    }
}
