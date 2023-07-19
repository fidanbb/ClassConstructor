using System;
namespace ClassAndConstructor.Models
{
	public class Calculator
	{
		public void Calculation(decimal num1,decimal num2,string operation)
		{
			 //operation = string.Empty;

			if (operation =="/" && num2 ==0)
			{
				Console.WriteLine("You cant divide to 0");
				return;
			}

			switch (operation)
			{
				case "+":
					Console.WriteLine($"Sum of {num1} and {num2} is equal to {num1+num2}");
					break;
                case "-":
                    Console.WriteLine($"Subtraction of {num1} and {num2} is equal to {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"SProduct of {num1} and {num2} is equal to {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"Division of {num1} and {num2} is equal to {num1 / num2}");
                    break;

            }

			
		}
	}
}

