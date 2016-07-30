using System;

namespace NumbersInReversedOrder
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbers = Console.ReadLine ();
			Console.WriteLine (reverseOrder(numbers));

		}
		public static string reverseOrder(string input){
			char[] charArray = input.ToCharArray ();
			Array.Reverse (charArray);
			return new string (charArray);
		}
	}
}
