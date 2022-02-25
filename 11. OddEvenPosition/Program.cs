using System;

namespace _11._OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInherit = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int backInTime = 1800;
            int yearsIvan = 18;
            double moneySpend = moneyInherit;
            for ( int i = 1800; i <= year; i++)
            { 
                yearsIvan++;
                if(i % 2 == 0)
                {
                    moneySpend -= 12000;
                }
                else
                {
                    double oddYear = 12000 +  (yearsIvan-1)*50;
                    moneySpend -= oddYear;
                    
                }
            }
            if (moneySpend < 0)
            {
                Console.WriteLine($"He will need {Math.Abs(moneySpend):f2} dollars to survive.");
                //Console.WriteLine($"Yes! He will live a carefree life and will have {moneySpend:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneySpend:f2} dollars left.");
            }
        }
    }
}
