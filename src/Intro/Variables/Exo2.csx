using System;

int number1, number2;

Console.WriteLine("Enter the first number");
number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number");
number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Before swapping: ");
Console.WriteLine("Number 1: " + number1);
Console.WriteLine("Number 2: " + number2);

number1 = number1 + number2;
number2 = number1 - number2;
number1 = number1 - number2;

Console.WriteLine("After swapping: ");
Console.WriteLine("Number 1: " + number1);
Console.WriteLine("Number 2: " + number2);
