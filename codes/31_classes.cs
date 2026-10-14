using System;

// Create objects from the Human class
Human person1 = new Human();
person1.name = "Maaz";
person1.age = 20;

Human person2 = new Human();
person2.name = "Ali";
person2.age = 22;

// Each object has its own data
person1.Introduce();
person2.Introduce();

person1.Eat();
person2.Sleep();

// Define the class below the top-level code
class Human
{
    // Fields store data
    public string name = "";
    public int age;

    // Methods define actions
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
    }

    public void Eat()
    {
        Console.WriteLine($"{name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{name} is sleeping.");
    }
}