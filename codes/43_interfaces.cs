using System;

// Different classes can implement the same interface
IMovable[] vehicles =
{
    new Car(),
    new Bicycle()
};

foreach (IMovable vehicle in vehicles)
{
    vehicle.Move();
}

// Interface: defines what implementing classes must do
interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("The car drives using its engine.");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("The bicycle moves when you pedal.");
    }
}