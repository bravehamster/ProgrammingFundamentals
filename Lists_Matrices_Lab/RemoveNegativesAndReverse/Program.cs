using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> numbers = Console.ReadLine ().Split (' ').Select (int.Parse).ToList ();
			int curr = 0;
			while (curr<numbers.Count) {
				if (numbers[curr]<0) {
					numbers.RemoveAt (curr);
					curr--;
				}
				curr++;
			}
			numbers.Reverse ();
			if (numbers.Count == 0) {
				Console.WriteLine ("empty");
			} else {
				Console.WriteLine (string.Join(" ", numbers));
			}

		}
	}
}
