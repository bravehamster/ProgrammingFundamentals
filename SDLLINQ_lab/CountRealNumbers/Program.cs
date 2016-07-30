using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double[] input = Console.ReadLine ().Split (' ').Select (double.Parse).ToArray ();

			SortedDictionary<double, int> counts = new SortedDictionary<double, int> ();

			foreach (var num in input) {
				if (counts.ContainsKey (num)) {
					counts [num]++;
				} else {
					counts [num] = 1;
				}
			}

			foreach (var entry in counts) {
				Console.WriteLine ("{0} -> {1}", entry.Key, entry.Value);
			}
		}
	}
}
