using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double sumElectricity = 0;
            double internet = 15*months;
            double water = 20*months;
            for(int i =1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                sumElectricity += electricity;   
            }
            Console.WriteLine($"Electricity: {sumElectricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv"); 
            Console.WriteLine($"Internet: {internet:f2} lv");
            double sumOthers = internet + water + sumElectricity;
            double other = sumOthers + sumOthers * 0.2;
            Console.WriteLine($"Other: {other:f2} lv");
            double sum = (internet + water + other+ sumElectricity)/months;
            Console.WriteLine($"Average: {sum:f2} lv");
        }
    }
}
