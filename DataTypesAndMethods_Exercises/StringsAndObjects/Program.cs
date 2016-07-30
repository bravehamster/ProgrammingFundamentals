using System;

namespace StringsAndObjects
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string wrld = "World";
			string hll = "Hello";

			object concat = hll + " " + wrld;
			string final = (string)concat;

			Console.WriteLine (final);
		}
	}
}
