using System;

// Base class: Animal
class Animal
{
    public void DisplayAnimal()
    {
        Console.WriteLine("I am an Animal");
    }
}

// Derived class: Dog (inherits from Animal)
class Dog : Animal
{
    public void DisplayDog()
    {
        Console.WriteLine("I have four legs");
    }
}

class Program
{
    static void Main()
    {
        // Create an array of Animal objects
        Animal[] animals = new Animal[2];

        // Create instances of Animal and Dog
        animals[0] = new Animal();
        animals[1] = new Dog();

        // Display the messages
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].DisplayAnimal(); // This method is from the base class
            if (animals[i] is Dog) // Check if the current object is of type Dog
            {
                Dog dog = (Dog)animals[i]; // Explicitly cast to Dog type
                dog.DisplayDog(); // Call the method specific to Dog class
            }
            Console.WriteLine();
        }
    }
}
