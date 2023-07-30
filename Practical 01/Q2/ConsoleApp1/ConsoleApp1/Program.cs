using System;

namespace BasicArithmeticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Arithmetic Calculator!");

            // Get the first integer input
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            // Get the second integer input
            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            // Calculate and display the sum
            int sum = number1 + number2;
            Console.WriteLine($"Sum: {sum}");

            // Calculate and display the subtraction
            int subtraction = number1 - number2;
            Console.WriteLine($"Subtraction: {subtraction}");

            // Calculate and display the multiplication
            int multiplication = number1 * number2;
            Console.WriteLine($"Multiplication: {multiplication}");

            // Calculate and display the division
            if (number2 != 0)
            {
                double division = (double)number1 / number2;
                Console.WriteLine($"Division: {division}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
    }
}

