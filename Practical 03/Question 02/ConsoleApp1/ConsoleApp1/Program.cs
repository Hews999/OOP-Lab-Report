using System;

namespace BasicArithmeticOperations
{
    class ArithmeticOperations
    {
        private double operand1;
        private double operand2;

        public double Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }

        public double Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }

        public double Summation()
        {
            return operand1 + operand2;
        }

        public double Subtraction()
        {
            return operand1 - operand2;
        }

        public double Multiplication()
        {
            return operand1 * operand2;
        }

        public double Division()
        {
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return operand1 / operand2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Arithmetic Operations");

            ArithmeticOperations calculator = new ArithmeticOperations();

            Console.Write("Enter the first number: ");
            calculator.Operand1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            calculator.Operand2 = double.Parse(Console.ReadLine());

            double sum = calculator.Summation();
            double subtraction = calculator.Subtraction();
            double multiplication = calculator.Multiplication();
            double division = calculator.Division();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Subtraction: {subtraction}");
            Console.WriteLine($"Multiplication: {multiplication}");
            Console.WriteLine($"Division: {division}");
        }
    }
}
