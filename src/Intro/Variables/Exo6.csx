using System;

Console.WriteLine("Enter the principal:");
double principal = double.Parse(Console.ReadLine());


Console.WriteLine("Enter the rate in %:");
double rate = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the time in year:");
int time = int.Parse(Console.ReadLine());

double interest = (principal * rate * time) / 100.0;
Console.WriteLine("Interest = " + interest);
