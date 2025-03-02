// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Zmiana testowa 1");

var a = 5;
Console.WriteLine(a + " test2");

int[] array = { 1, 2, 3, 4, 5, 44 };

double getAvarage(int[] a)
{
    return a.Average();
}

Console.WriteLine(getAvarage(array));