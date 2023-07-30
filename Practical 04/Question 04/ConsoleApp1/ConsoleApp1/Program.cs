using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());

        int[] array1 = new int[size];
        int[] array2 = new int[size];
        int[] vectorSum = new int[size];
        int[] vectorProduct = new int[size];

        // Input values for the first array
        Console.WriteLine("Enter values for the first array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        // Input values for the second array
        Console.WriteLine("\nEnter values for the second array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        // Calculate scalar sum
        int scalarSum = 0;
        for (int i = 0; i < size; i++)
        {
            scalarSum += array1[i];
        }

        // Calculate vector sum
        for (int i = 0; i < size; i++)
        {
            vectorSum[i] = array1[i] + array2[i];
        }

        // Calculate vector product
        for (int i = 0; i < size; i++)
        {
            vectorProduct[i] = array1[i] * array2[i];
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Scalar Sum: {scalarSum}");

        Console.Write("Vector Sum: [ ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{vectorSum[i]} ");
        }
        Console.WriteLine("]");

        Console.Write("Vector Product: [ ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{vectorProduct[i]} ");
        }
        Console.WriteLine("]");
    }
}
