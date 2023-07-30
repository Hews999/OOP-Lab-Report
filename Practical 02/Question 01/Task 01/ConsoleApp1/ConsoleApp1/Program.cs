using System;

namespace KilometerToMeterConverter
{
    class ConvertValues
    {
        public void kilometerToMeter()
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            double meters = kilometers * 1000;
            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilometer to Meter Converter");

            ConvertValues converter = new ConvertValues();
            converter.kilometerToMeter();
        }
    }
}
