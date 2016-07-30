using System;

namespace PrintStringLetters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string word = Console.ReadLine ();

			for (int i = 0; i < word.Length; i++) {
				Console.WriteLine ("str[{0}] -> '{1}'", i, word[i]);
			}
		}
	}
}
