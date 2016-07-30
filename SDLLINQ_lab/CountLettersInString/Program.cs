using System;
using System.Linq;

namespace CountLettersInString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ().ToLower ();
			int[] occurences = new int[input.Max ()+1];

			foreach (var c in input) {
				occurences [c]++;
			}

			for (int i = 0; i < occurences.Length; i++) {
				if (occurences[i] != 0) {
					Console.WriteLine ("{0} -> {1}",(char) i ,occurences[i]);
				}
			}
		}


	}
}
