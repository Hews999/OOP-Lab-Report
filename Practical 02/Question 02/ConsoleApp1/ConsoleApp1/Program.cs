using System;

namespace CircleAreaCircumferenceCalculator
{
    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle Area and Circumference Calculator");

            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            FindValues calculator = new FindValues();
            double area = calculator.FindArea(radius);
            double circumference = calculator.FindCircumference(radius);

            Console.WriteLine($"Area of the circle: {area}");
            Console.WriteLine($"Circumference of the circle: {circumference}");
        }
    }
}
