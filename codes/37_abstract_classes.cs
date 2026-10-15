using System;

Car car = new Car();
Bicycle bicycle = new Bicycle();

car.ShowInfo();
car.Move();

bicycle.ShowInfo();
bicycle.Move();

// Abstract base class
abstract class Vehicle
{
    // Regular method: inherited by child classes
    public void ShowInfo()
    {
        Console.WriteLine("This is a vehicle.");
    }

    // Abstract method: child classes must provide its behaviour
    public abstract void Move();
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("The car drives on the road.");
    }
}

class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("The bicycle moves when you pedal.");
    }
}