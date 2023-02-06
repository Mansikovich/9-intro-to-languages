using System;
					
public class Program
{
	public static void Main()
	{



int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2;
		}
		
		Console.WriteLine(CalculateSumm(72, 16));
	}
}