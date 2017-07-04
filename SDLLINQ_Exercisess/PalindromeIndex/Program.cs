using System;

namespace PalindromeIndex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string word = Console.ReadLine ();
			int idx = -1;
			if (isPalindrome (word)) {
				Console.WriteLine ("-1");
			} else {
				for (int i = 0; i < word.Length; i++) {
					string tmp = word.Remove (i, 1);
					if (isPalindrome (tmp)) {
						idx = i;
					}
				}
				if (idx>=0) {
					Console.WriteLine (idx);
				}
			}


		}

		static bool isPalindrome(string s){
			int check = 0;
			for (int i = 0; i < s.Length/2; i++) {
				if (s[i] == s[s.Length-i-1]) {
					check++;
				}
			}
			if (check == s.Length / 2) {
				return true;
			} else {
				return false;
			}

		}
	}
}
