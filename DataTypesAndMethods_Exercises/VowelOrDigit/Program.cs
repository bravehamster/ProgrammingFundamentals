using System;

namespace VowelOrDigit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] vowels = {'a', 'e', 'o', 'u', 'i'};
			char[] digits = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

			char input = char.Parse (Console.ReadLine ());
			bool isVowel = false;
			bool isDigit = false;


			for (int i = 0; i < vowels.Length; i++) {
				if (input == vowels[i]) {
					isVowel = true;
					break;
				}	
			}
			if (!isVowel) {
				for (int i = 0; i < digits.Length; i++) {
					if (input == digits[i]) {
						isDigit = true;
						break;
					}
				}	
			}

			if (isVowel) {
				Console.WriteLine ("vowel");
			}
			else if (isDigit) {
				Console.WriteLine ("digit");
			} else {
				Console.WriteLine ("other");
			}


		}
	}
}
