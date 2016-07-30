using System;

namespace EnglishNameOfLastDigit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string number = Console.ReadLine ();
			Console.WriteLine (returnNameOfLastDigit (number));
		}
		public static string returnNameOfLastDigit(string input){
			string[] names = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			char[] charArray = input.ToCharArray();
			int number = int.Parse(charArray [charArray.Length - 1].ToString());
			return names[number];
		}
	}
}
