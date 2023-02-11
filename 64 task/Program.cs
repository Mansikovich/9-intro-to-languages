using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{
int n = InputInt("Введите положительное число: ");
int m = 1;

Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
}
}
}