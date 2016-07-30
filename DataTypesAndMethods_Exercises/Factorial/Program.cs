using System;
using System.Numerics;

namespace Factorial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			printFactorial (n);
		}

		public static void printFactorial(int number){
			BigInteger result = 1;
			while (number>1) {
				result *= number;
				number -= 1;
			}
			Console.WriteLine (result);
		}
	}
}
