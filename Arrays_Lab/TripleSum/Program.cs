using System;
using System.Linq;

namespace TripleSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			int counter = 0;
			for (int i = 0; i < arr.Length; i++) {
				for (int j = i+1; j < arr.Length; j++) {
					int sum = arr [i] + arr [j];
					if (arr.Contains(sum)) {
						Console.WriteLine ("{0} + {1} == {2}", arr[i], arr[j], sum);
						counter += 1;
					}
				}
			}
			if (counter == 0) {
				Console.WriteLine ("No");
			}
		}
	}
}
