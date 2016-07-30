using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> inputList = Console.ReadLine ().Split (' ').Select (int.Parse).ToList ();

			int[] occurence = new int[1001];

			foreach (int number in inputList) {
				occurence [number]++;
			}

			for (int i = 0; i < occurence.Length; i++) {
				if (occurence[i]!=0) {
					Console.WriteLine ("{0} => {1}", i, occurence[i]);
				}
			}

		}
	}
}
