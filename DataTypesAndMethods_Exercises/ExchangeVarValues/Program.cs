using System;

namespace ExchangeVarValues
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 5;
			int b = 10;

			Console.WriteLine ($"Before:\na = {a}\nb = {b}");

			int temp = a;
			a = b;
			b = temp;

			Console.WriteLine ($"After:\na = {a}\nb = {b}");

		}
	}
}
