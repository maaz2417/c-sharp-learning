using System;

// Call a static method using the class name
Car.ShowCount(); // Cars created: 0

Car car1 = new Car("Toyota");
Car car2 = new Car("Honda");

// Call instance methods using objects
car1.Drive();
car2.Drive();

// Both objects share the same static counter
Car.ShowCount(); // Cars created: 2

class Car
{
    // Instance field: each object has its own brand
    public string brand;

    // Static field: one value shared by the class
    public static int count = 0;

    public Car(string brand)
    {
        this.brand = brand;
        count++;
    }

    // Instance method: uses this object's data
    public void Drive()
    {
        Console.WriteLine($"The {brand} is driving.");
    }

    // Static method: belongs to the class
    public static void ShowCount()
    {
        Console.WriteLine($"Cars created: {count}");
    }
}