using System;
namespace ClassWorkConstructor
{
	public class Calculator
	{
		public int num1;
		public int num2;

		public Calculator(int a, int b)
		{
			num1 = a;
			num2 = b;
		}

		public void Sum(int num)
		{
			int sum = 0;

			for (int i = num1; i < num2; i++)
			{
				sum += i;
			}

			sum += num;

			Console.WriteLine("Sum of numbers: "+sum);
		}
	}
}

