using System;

Console.WriteLine("Convertion between Celsius and Fahrenheit");

Console.WriteLine("Enter a temperature in Celsius unit :");
double celsius = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a temperature in Fahrenheit unit :");
double fahrenheit = double.Parse(Console.ReadLine());

double toFahrenheit = celsius * (9.0 / 5.0) + 32;
double toCelsius = (fahrenheit - 32) * (5.0 / 9.0);

Console.WriteLine(celsius + "°C = " + toFahrenheit + "°F");
Console.WriteLine(fahrenheit + "°F = " + toCelsius + "°C");
