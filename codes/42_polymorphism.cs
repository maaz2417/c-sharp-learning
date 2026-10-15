using System;

// Store different child objects in one base-class array
Animal[] animals =
{
    new Dog(),
    new Cat(),
    new Cow()
};

// Same method call, different behaviour for each object
foreach (Animal animal in animals)
{
    animal.Speak();
}

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog: Woof!");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat: Meow!");
    }
}

class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cow: Moo!");
    }
}