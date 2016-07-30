using System;
using System.Linq;

namespace IndexOfLetters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] charray = new char[26];
			for (int i = 0; i < 26; i++) {
				charray [i] = (char)(i + 97);
			}

			char[] inputArray = Console.ReadLine ().ToCharArray ();

			for (int i = 0; i < inputArray.Length; i++) {
				for (int j = 0; j < charray.Length; j++) {
					if (inputArray[i] == charray[j]) {
						Console.WriteLine ("{0} -> {1}", inputArray[i], j);
					}
				}
			}
		}
	}
}
