using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfStudents = GetAmountOfStudents();

            Console.WriteLine(amountOfStudents);

        }

        static int GetAmountOfStudents()
        {
            Console.WriteLine("Enter the number of students");
            int amountOfStudents = int.Parse(Console.ReadLine());
            return amountOfStudents;
        }
    }
}
