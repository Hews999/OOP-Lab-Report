using System;

namespace ArrayProcessorApp
{
    class ArrayProcessor
    {
        public void ProcessArray(int size)
        {
            int[] array = new int[size * 2];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                int value = int.Parse(Console.ReadLine());

                array[i * 2] = value;
                array[i * 2 + 1] = 0;
            }

            Console.WriteLine("\nValues inside the array:");
            foreach (int value in array)
            {
                Console.Write($"{value} ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Processor App");

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            ArrayProcessor processor = new ArrayProcessor();
            processor.ProcessArray(size);

            Console.WriteLine(); // Adding a newline for better output formatting
        }
    }
}
