using System;

// Create an array containing three Car objects
Car[] cars =
{
    new Car("Toyota", "White"),
    new Car("Honda", "Black"),
    new Car("BMW", "Blue")
};

// Access one object using its index
Console.WriteLine($"First car: {cars[0].brand}");

// Change a field on the second object
cars[1].color = "Red";

// Call a method on every object
Console.WriteLine("\nAll cars:");

foreach (Car car in cars)
{
    car.ShowDetails();
}

Console.WriteLine($"\nTotal cars: {cars.Length}");

class Car
{
    public string brand;
    public string color;

    public Car(string brand, string color)
    {
        this.brand = brand;
        this.color = color;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{color} {brand}");
    }
}