using System;

namespace BooleanVariable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			bool var = Convert.ToBoolean(input.ToLower());
			if (var) {
				Console.WriteLine ("Yes");
			} else {
				Console.WriteLine ("No");
			}
		}
	}
}
