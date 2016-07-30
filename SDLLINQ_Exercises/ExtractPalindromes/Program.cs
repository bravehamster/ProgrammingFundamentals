using System;
using System.Collections.Generic;
using System.Linq;
namespace ExtractPalindromes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<string> words = Console.ReadLine ().Split (' ', '.', ',', '!', '?')
				.Where (x=>!string.IsNullOrWhiteSpace (x))
				.Where (x=>isPalindrome(x))
				.Distinct ()
				.OrderBy (x=>x)
				.ToList ();

			Console.WriteLine (string.Join (", ",words));
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
