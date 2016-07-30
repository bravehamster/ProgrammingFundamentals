using System;

namespace MaxMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int max = int.MinValue;
			for (int i = 0; i < 3; i++) {
				max = getMax (int.Parse (Console.ReadLine ()), max);
			}
			Console.WriteLine (max);
			

		}
		public static int getMax(int a, int b){
			return a>b ? a : b;
		}
	}
}
