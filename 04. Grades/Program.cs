using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //четене 
            double evaluationThree = 0;
            double evaluationFour = 0;
            double evaluationFive = 0;
            double evaluationSix = 0;
            double evaluationSixCount = 0;
            double evaluationFiveCount = 0;
            double evaluationFourCount = 0;
            double evaluationTreeCount = 0;
            double evaluation = 0;
            int students = int.Parse(Console.ReadLine());
            //за всеки студент неговата оценка 
            for (int i = 1; i <= students; i++)
            {
                evaluation = double.Parse(Console.ReadLine());
                if (evaluation >= 2 && evaluation <= 2.99)
                {
                    evaluationTreeCount++;
                    evaluationThree += evaluation;            
                }
                if (evaluation >= 3 && evaluation <= 3.99)
                {
                    evaluationFourCount++;
                    evaluationFour += evaluation;
                }
                if (evaluation >= 4 && evaluation <= 4.99)
                {
                    evaluationFiveCount++;
                    evaluationFive += evaluation;               
                }
                if (evaluation >= 5)
                {
                    evaluationSixCount++;
                    evaluationSix += evaluation;                   
                }
            }
                double sum = (evaluationSix + evaluationFive + evaluationFour + evaluationThree) / students;
                double topStudents = (evaluationSixCount / students)*100;
                Console.WriteLine($"Top students: {topStudents:f2}%");
                double betweenFourAndFive = (evaluationFiveCount / students)*100;
                Console.WriteLine($"Between 4.00 and 4.99: { betweenFourAndFive:f2}%");
                double betweenTreeAndFour = (evaluationFourCount / students)*100;
                Console.WriteLine($"Between 3.00 and 3.99: {betweenTreeAndFour:f2}%");
                double fail = evaluationTreeCount / students*100;
                Console.WriteLine($"Fail: {fail:f2}%");
                Console.WriteLine($"Average: {sum:f2}");         
        }
    }
}
