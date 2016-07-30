using System;

namespace IntToHexAndBinary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = int.Parse(Console.ReadLine ());

			Console.WriteLine (Convert.ToString(num, 16).ToUpper());
			Console.WriteLine (Convert.ToString(num, 2));
		}
	}
}
