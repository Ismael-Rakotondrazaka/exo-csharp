using System;

Console.WriteLine("Enter the radius:");
double radius = double.Parse(Console.ReadLine());

double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine("The area is " + area);
