using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = " ";

            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine($"Enter the name of the student #{i+1} name");
                string name = Console.ReadLine();
                studentNames[i]= name;
                Console.WriteLine($"Enter the grade for student number {i+1}");
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade = averageGrade + grade;

                if (grade > highestGrade) 
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }



            }
            averageGrade = averageGrade / amountOfStudents;
            Console.WriteLine($"The average grade of the class is {averageGrade}");
            Console.WriteLine($"The Highest grade of the class is {highestGrade}");
            Console.WriteLine($"The Highest grade Name of the class is {highestGradeName}");
        }
        //Console.ReadLine();
        //Console.ReadKey();

    }
}
