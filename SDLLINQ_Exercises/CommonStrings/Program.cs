using System;

namespace CommonStrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string a = Console.ReadLine ();
			string b = Console.ReadLine ();

			bool containsSubstr = false;

			if (a.Length >= b.Length) {
				for (int i = 0; i < b.Length; i++) {
					for (int j = 1; j < b.Length - i + 1; j++) {
						string tmp = b.Substring (i, j);
						//Console.WriteLine (tmp);
						if (a.Contains (tmp)) {
							containsSubstr = true;
						}
					}
				}
			} else {
				for (int i = 0; i < a.Length; i++) {
					for (int j = 1; j < a.Length - i + 1; j++) {
						string tmp = b.Substring (i, j);
						//Console.WriteLine (tmp);
						if (a.Contains (tmp)) {
							containsSubstr = true;
						}
					}
				}
			}

			Console.WriteLine (containsSubstr==true?"yes":"no");

		}
	}
}
