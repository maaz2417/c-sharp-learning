using System;

// Use the same generic class with different types
Box<int> numberBox = new Box<int>(100);
Box<string> textBox = new Box<string>("Hello, Maaz!");
Box<double> priceBox = new Box<double>(19.99);

numberBox.ShowValue();
textBox.ShowValue();
priceBox.ShowValue();

// Value is an int because this is a Box<int>
numberBox.Value = 200;
Console.WriteLine($"Updated number: {numberBox.Value}");

// This would cause a compile error:
// numberBox.Value = "Hello";

// Generic class: T represents the chosen type
class Box<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }

    public void ShowValue()
    {
        Console.WriteLine($"Value: {Value}");
    }
}