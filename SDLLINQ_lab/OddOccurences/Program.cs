using System;
using System.Collections.Generic;

namespace OddOccurences
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] input = Console.ReadLine ().ToLower (). Split (' ');
			Dictionary<string, int> occur = new Dictionary<string, int>();

			foreach (var word in input) {
				if (occur.ContainsKey (word)) {
					occur [word]++;
				} else {
					occur [word] = 1;
				}
			}

			string output = "";

			foreach (var entry in occur) {
				if (entry.Value%2!=0) {
					output += (entry.Key + ", ");
				}
			}

			Console.WriteLine (output.TrimEnd (' ', ','));

		}
	}
}
