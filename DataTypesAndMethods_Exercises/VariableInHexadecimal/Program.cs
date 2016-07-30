using System;

namespace VariableInHexadecimal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string num = Console.ReadLine ();
			int number = Convert.ToInt32 (num, 16);
			Console.WriteLine (number);
		}
	}
}
