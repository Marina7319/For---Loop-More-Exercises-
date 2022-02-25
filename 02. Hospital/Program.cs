using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int patients = 0;
            int days = int.Parse(Console.ReadLine());//6
            double patientsDontSaw = 0;
            double patientsSaw = 0;
            int doctor = 7;
            for (int i = 1; i <= days; i++)
            {
                patients = int.Parse(Console.ReadLine());
                if ((i % 3 == 0) && (patientsDontSaw > patientsSaw))
                {
                    doctor += 1;
                }
                if(patients > doctor)
                {
                    patientsSaw += doctor;//прегледани пациенти 
                    patientsDontSaw += patients - doctor; // непрегледани пациенти 
                }else
                {
                    patientsSaw += patients;//прегледани пациенти
                }
            }
            //изчисляване непрегледани и прегледани пациенти 
            Console.WriteLine($"Treated patients: {patientsSaw}.");
            Console.WriteLine($"Untreated patients: {patientsDontSaw}.");
        }
    }
}
