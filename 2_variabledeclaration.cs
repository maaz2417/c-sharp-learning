using System;

class VariableDeclarationProgram
{
    static void Main()
    {
        // Declare variables
        string name = "Maaz";
        int age = 20;
        double height = 1.75;
        char grade = 'A';
        bool isStudent = true;

        // Display their values
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height} metres");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Is a student: {isStudent}");

        // Change a variable
        age = 21;
        Console.WriteLine($"Updated age: {age}");
    }
}