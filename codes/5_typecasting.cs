using System;

// 1. Implicit conversion: int → double (automatic)
int number = 10;
double decimalNumber = number;

Console.WriteLine($"Implicit conversion: {decimalNumber}");

// 2. Explicit casting: double → int (removes the decimal part)
double price = 19.99;
int wholePrice = (int)price;

Console.WriteLine($"Explicit cast: {wholePrice}"); // 19, not 20

// 3. Convert numeric text to an int
string ageText = "20";
int age = Convert.ToInt32(ageText);

Console.WriteLine($"Age next year: {age + 1}"); // 21

// 4. Convert a number to text
int score = 95;
string scoreText = score.ToString();

Console.WriteLine($"Score as text: {scoreText}");