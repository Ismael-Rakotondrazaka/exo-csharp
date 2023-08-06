using System;

int i = 2;
Console.WriteLine("integer: " + i);

long l = 3L;
Console.WriteLine("long: " + l);

float f = 2.12f;
Console.WriteLine("float: " + f);

double d = 3.14D;
Console.WriteLine("double: " + d);

char c = 'A';
Console.WriteLine("char: " + c);

string str = "Hello";
Console.WriteLine("string: " + str);

bool b = true;
Console.WriteLine("bool: " + b);

int[] intArr1 = new int[] { 1, 2, 3 };
int[] intArr2 = new int[3] { 1, 2, 3 };
int[] intArr3 = { 1, 2, 3 };
Console.WriteLine("array :");
foreach (int item in intArr1)
{
    Console.WriteLine(item);
}