﻿using System;
					
public class Program
{
	public static void Main()
	{



int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"->{CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
	}
}