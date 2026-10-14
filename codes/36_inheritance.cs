using System;

Car car = new Car();
car.brand = "Toyota"; // Inherited field
car.ShowBrand();      // Inherited method
car.Drive();          // Car's own method

Bicycle bicycle = new Bicycle();
bicycle.brand = "Giant";
bicycle.ShowBrand();
bicycle.Pedal();

// Base class (parent)
class Vehicle
{
    public string brand = "";

    public void ShowBrand()
    {
        Console.WriteLine($"Brand: {brand}");
    }
}

// Derived class (child)
class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine($"The {brand} car is driving.");
    }
}

// Another derived class
class Bicycle : Vehicle
{
    public void Pedal()
    {
        Console.WriteLine($"The {brand} bicycle is being pedalled.");
    }
}