using System;

namespace FibbonacciNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (printNthFibb(int.Parse(Console.ReadLine())));
		}

		public static int printNthFibb(int n){
			int prev2 = 0;
			int prev1 = 1;
			int current = 0;

			for (int i = 0; i <= n; i++) {
				current = prev1 +prev2;
				prev2 = i==0 ? 0 : prev1;
				prev1 = current;
			}

			return current;
		}
	}
}
