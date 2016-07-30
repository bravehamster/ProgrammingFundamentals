using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<string> lowerCase = new List<string>();
			List<string> upperCase = new List<string>();
			List<string> mixedCase = new List<string>();

			List<string> inputList = Console.ReadLine ().Split (
				new char[] {',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\',  '/', '[', ']', ' '}, 
				StringSplitOptions.RemoveEmptyEntries).ToList ();

			foreach (string word in inputList) {
				int lowerCounter = 0;
				int upperCounter = 0;

				foreach (char letter in word) {
					if (char.IsLower (letter)) {
						lowerCounter++;
					}
					else if (char.IsUpper (letter)) {
						upperCounter++;
					}
				}

				if (word.Length == lowerCounter) {
					lowerCase.Add (word);
				} else if (word.Length == upperCounter) {
					upperCase.Add (word);
				} else {
					mixedCase.Add (word);
				}
					
			}

			Console.WriteLine ("Lower-case: {0}", string.Join (", ", lowerCase));
			Console.WriteLine ("Mixed-case: {0}", string.Join (", ", mixedCase));
			Console.WriteLine ("Upper-case: {0}", string.Join (", ", upperCase));


		}
	}
}
