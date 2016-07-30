using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseWordsInSentence
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Get input
			string wordsOrig = Console.ReadLine ();

			// Get individual words
			List<string> words = wordsOrig.Split ('.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ')
				.Where (s => !string.IsNullOrWhiteSpace (s)).ToList ();

			// Get only letters in a single string
			string letters = "";
			foreach (string word in words) {
				letters = string.Concat (letters, word);
			}
				
			// Get only non-letters
			List<string> separatorsOnly = wordsOrig.Split (letters.ToCharArray ()).Where (s => !string.IsNullOrEmpty (s)).ToList ();

			// Reverse words order
			for (int i = 0; i < words.Count/2; i++) {
				string temp = words [i];
				words [i] = words [words.Count - i - 1];
				words [words.Count - i - 1] = temp;
			}
			// Print reversed words + non-letters after them
			for (int i = 0; i < words.Count; i++) {
				Console.Write (words[i] + separatorsOnly[i]);
			}
		}
	}
}
