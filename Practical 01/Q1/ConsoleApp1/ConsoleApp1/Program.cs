using System;

namespace StudentGradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Calculator!");

            // Get the student's name
            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();

            // Get the student's marks
            Console.Write("Enter the student's marks: ");
            int studentMarks = int.Parse(Console.ReadLine());

            char studentGrade;

            if (studentMarks >= 75 && studentMarks <= 100)
            {
                studentGrade = 'A';
            }
            else if (studentMarks >= 60 && studentMarks <= 74)
            {
                studentGrade = 'B';
            }
            else if (studentMarks >= 50 && studentMarks <= 59)
            {
                studentGrade = 'C';
            }
            else if (studentMarks >= 40 && studentMarks <= 49)
            {
                studentGrade = 'D';
            }
            else
            {
                studentGrade = 'F'; // Fail
            }

            Console.WriteLine($"{studentName}'s grade is: {studentGrade}");
        }
    }
}
