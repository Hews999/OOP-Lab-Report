using System;
public class ConvertValues
{
    public static void KilometerToMeter(int kilometer)
    {
        // Calculate the meter value from the kilometer value.
        int meter = kilometer * 1000;
        // Display the meter value.
        Console.WriteLine("The meter value is {0}.", meter);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Declare a variable to store the user input kilometer value.
        int kilometer;
        // Prompt the user to enter a kilometer value.
        Console.WriteLine("Enter a kilometer value: ");
        kilometer = Convert.ToInt32(Console.ReadLine());
        // Create an object of the ConvertValues class.
        var convertValues = new ConvertValues();
        // Call the KilometerToMeter method on the ConvertValues object, passing the kilometer value as 
        a parameter.
 convertValues.KilometerToMeter(kilometer);
    }
}

