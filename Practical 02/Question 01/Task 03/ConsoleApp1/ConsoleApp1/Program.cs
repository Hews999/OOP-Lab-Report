using System;

namespace KilometerToMeterConverter
{
    class ConvertValues
    {
        public double KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            return meters;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilometer to Meter Converter");

            Console.Write("Enter the distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meters = converter.KilometerToMeter(kilometers);

            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
        }
    }
}

