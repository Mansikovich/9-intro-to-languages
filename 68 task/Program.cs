using System;
					
public class Program
{
	public static void Main()
	{


int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


int n(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return k(m - 1, 1);
    else
        return k(m - 1, k(m, n - 1));
}
	}
}