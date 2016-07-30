using System;
using System.Linq;

namespace PairsByDifference
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numarray = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			int difference = int.Parse (Console.ReadLine ());

			int counter = 0;

			for (int i = 0; i < numarray.Length; i++) {
				for (int j = i+1; j < numarray.Length; j++) {
					if (Math.Abs(numarray[i]-numarray[j]) == difference) {
						counter++;			
					}
				}
			}


			Console.WriteLine (counter);

		}
	}
}
