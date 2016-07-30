using System;

namespace ReverseCharacters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] myArray = new char[3];
			for (int i = 0; i < 3; i++) {
				char b = char.Parse (Console.ReadLine ());
				myArray[i] = b;
			}
			Array.Reverse (myArray);
			Console.WriteLine (myArray);

		}
	}
}
