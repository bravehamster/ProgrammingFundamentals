using System;

namespace OccurencesInString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string txt = Console.ReadLine ().ToLower ();
			string substr = Console.ReadLine ().ToLower ();

			int occur = 0;
			for (int i = 0; i <= txt.Length - substr.Length; i++) {
				int match = 0;
				for (int j = 0; j < substr.Length; j++) {
					if (substr[j] == txt[i+j]) {
						match ++;
					}
				}
				if (match==substr.Length) {
					occur++;
				}
			}


			Console.WriteLine (occur);
		}
	}
}
