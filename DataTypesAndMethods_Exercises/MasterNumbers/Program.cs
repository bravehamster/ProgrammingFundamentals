using System;

namespace MasterNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number = int.Parse (Console.ReadLine ());
			for (int i = 1; i < number; i++) {
				if (IsSumOfDigitsDivisibleBySeven(i) && DoesItContainAnEvenDigit(i) && IsItPalindrome(i)) {
					Console.WriteLine (i);
				}
			}
		}

		public static bool IsSumOfDigitsDivisibleBySeven(int number){
			int sumOfDigits = 0;
			while (number>0) {
				sumOfDigits += number % 10;
				number /= 10;
			}

			if (sumOfDigits % 7 == 0) {
				return true;
			} else {
				return false;
			}
		}

		public static bool DoesItContainAnEvenDigit(int number){
			bool containsEven = false;
			foreach (char digit in number.ToString()) {
				if (digit == 0 || digit % 2 == 0) {
					containsEven = true;
					break;
				}
			}
			return containsEven;
		}

		public static bool IsItPalindrome(int number){
			char[] charArray = number.ToString ().ToCharArray ();
			bool isPalindrome = true;
			for (int i = 0; i <= charArray.Length-1; i++) {
				if (charArray[i] != charArray[charArray.Length-i-1]) {
					return false;
				}
			}
			return isPalindrome;
		}

	}
}
